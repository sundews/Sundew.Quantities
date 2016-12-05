// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitSystem.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Sundew.Base.Computation;
    using Sundew.Quantities.Core.Operations;
    using Sundew.Quantities.Parsing;
    using Sundew.Quantities.Parsing.Errors;
    using Sundew.Quantities.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Registration;
    using Sundew.Quantities.Representations.Evaluation;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;

    /// <summary>
    /// Stores the currently load unit system.
    /// This class must be initialized with the wished units.
    /// </summary>
    public partial class UnitSystem : IUnitSystem
    {
        private readonly object unitSystemLock = new object();

        private IExpressionParser expressionParser;

        private bool isInitialized;

        private ILexicalAnalyzer lexicalAnalyzer;

        private IQuantityOperations quantityOperations;

        private IQuantityParser quantityParser;

        private IUnitFactory unitFactory;

        private UnitRegistry unitRegistry;

        /// <summary>
        /// Gets the dependencies.
        /// </summary>
        /// <value>
        /// The dependencies.
        /// </value>
        public UnitSystemDependencies Dependencies { get; private set; }

        /// <summary>
        /// Gets the quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="cultureInfo">The culture information.</param>
        /// <returns>A new <see cref="Quantity"/>.</returns>
        public Quantity GetQuantity(string quantity, CultureInfo cultureInfo)
        {
            return
                this.quantityParser.Parse(
                    this.lexicalAnalyzer.Analyze(quantity, true).Value,
                    new ParseSettings(cultureInfo, true, true)).Value;
        }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>
        /// An <see cref="IUnit" /> based on the specified <see cref="Expression"/>.
        /// </returns>
        public IUnit GetUnit(Expression expression)
        {
            var unitExpression = expression as UnitExpression;
            if (unitExpression != null)
            {
                return unitExpression.Unit;
            }

            return this.unitFactory.Create(expression);
        }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <param name="unit">The unit as a string.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>
        /// An <see cref="IUnit" /> based on the specified <see cref="string" />.
        /// </returns>
        public Result<IUnit, Error<ExpressionError>> GetUnit(string unit, ParseSettings parseSettings)
        {
            var result = this.ParseExpression(unit, parseSettings);
            return Result.For(result, this.GetUnit);
        }

        /// <summary>
        /// Gets the prefixes.
        /// </summary>
        /// <returns>the prefixes.</returns>
        public IEnumerable<Prefix> GetPrefixes()
        {
            return this.unitRegistry.GetPrefixes();
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>the units.</returns>
        public IEnumerable<IUnit> GetUnits()
        {
            return this.unitRegistry.GetUnits();
        }

        /// <summary>
        /// Initializes the unit system.
        /// </summary>
        /// <param name="unitSystemDependencyFactory">The unit system dependency factory.</param>
        /// <param name="registerUnitAction">The register unit action.</param>
        /// <returns>A <see cref="UnitSystemDependencies"/>.</returns>
        public UnitSystemDependencies InitializeUnitSystem(
            IUnitSystemDependencyFactory unitSystemDependencyFactory,
            Action<IUnitRegistrar> registerUnitAction)
        {
            this.LockedAction(
                () =>
                    {
                        if (!this.isInitialized)
                        {
                            unitSystemDependencyFactory = unitSystemDependencyFactory
                                                          ?? new UnitSystemDependencyFactory(
                                                                 new ExpressionToFlatRepresentationConverter());
                            this.unitRegistry = unitSystemDependencyFactory.CreateUnitRegistry();
                            registerUnitAction?.Invoke(this.unitRegistry);
                            this.expressionParser = unitSystemDependencyFactory.CreateParser(this.unitRegistry);
                            this.lexicalAnalyzer =
                                unitSystemDependencyFactory.CreateLexicalAnalyzer(TokenMatching.CompositeUnit);
                            this.unitFactory = unitSystemDependencyFactory.CreateUnitFactory(this.unitRegistry);
                            this.quantityParser = unitSystemDependencyFactory.CreateParser(
                                this.expressionParser,
                                this.unitFactory);
                            this.quantityOperations =
                                unitSystemDependencyFactory.CreateQuantityOperations(this.unitFactory);
                            this.Dependencies = new UnitSystemDependencies(
                                this.unitRegistry,
                                this.lexicalAnalyzer,
                                this.expressionParser,
                                this.quantityParser,
                                this.unitFactory,
                                this.quantityOperations);
                            this.isInitialized = true;
                        }
                    });

            return this.Dependencies;
        }

        /// <summary>
        /// Initializes the unit system with defaults.
        /// </summary>
        /// <param name="unitSystemDependencyFactory">The unit system dependency factory.</param>
        /// <param name="registerUnitAction">The register unit action.</param>
        /// <returns>A <see cref="UnitSystemDependencies"/>.</returns>
        public UnitSystemDependencies InitializeUnitSystemWithDefaults(
            IUnitSystemDependencyFactory unitSystemDependencyFactory = null,
            Action<IUnitRegistrar> registerUnitAction = null)
        {
            return this.InitializeUnitSystem(
                unitSystemDependencyFactory,
                unitRegistrar =>
                    {
                        foreach (var unit in UnitDefinitions.GetDefaultPrefixes())
                        {
                            unitRegistrar.Register(unit);
                        }

                        foreach (var unit in UnitDefinitions.GetDefaultUnits())
                        {
                            unitRegistrar.Register(unit);
                        }

                        foreach (var derivedUnit in UnitDefinitions.GetDefaultDerivedUnit())
                        {
                            unitRegistrar.Register(derivedUnit);
                        }

                        registerUnitAction?.Invoke(unitRegistrar);
                    });
        }

        /// <summary>
        /// Resets the units for the unit system, afterwards the unit system must be initialized to be used again.
        /// </summary>
        public void ResetUnitSystem()
        {
            this.LockedAction(() => this.isInitialized = false);
        }

        internal Result<Expression, Error<ExpressionError>> ParseExpression(string unit, ParseSettings parseSettings)
        {
            var analysisResult = this.lexicalAnalyzer.Analyze(unit, parseSettings.ThrowOnError);
            if (analysisResult)
            {
                return this.expressionParser.Parse(analysisResult.Value, parseSettings);
            }

            return Result.Error(Error.From(ExpressionError.LexicalAnalysisFailed, null, analysisResult.Error));
        }

        private void LockedAction(Action action)
        {
            lock (this.unitSystemLock)
            {
                action();
            }
        }
    }
}