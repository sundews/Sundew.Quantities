// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitRegistry.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Registration;

using System.Collections.Generic;
using System.Linq;
using Sundew.Quantities.Parsing;
using Sundew.Quantities.Representations.Evaluation;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;
using Sundew.Quantities.Representations.Units;

/// <summary>
/// Registers units, prefixes and derived units.
/// </summary>
public class UnitRegistry : IUnitRegistrar, IUnitRegistry, IDerivedUnitRegistry
{
    private readonly Dictionary<FlatRepresentation, DerivedUnit> derivedUnits;

    private readonly IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter;

    private readonly Dictionary<string, Prefix> prefixDefinitions;

    private readonly Dictionary<double, Prefix> prefixValueDefinitions;

    private readonly Dictionary<string, IUnit> unitDefinitions;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitRegistry"/> class.
    /// </summary>
    /// <param name="expressionToFlatRepresentationConverter">The expression to flat representation converter.</param>
    public UnitRegistry(IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter)
    {
        this.expressionToFlatRepresentationConverter = expressionToFlatRepresentationConverter;
        this.unitDefinitions = new Dictionary<string, IUnit>();
        this.prefixDefinitions = new Dictionary<string, Prefix>();
        this.prefixValueDefinitions = new Dictionary<double, Prefix>();
        this.derivedUnits = new Dictionary<FlatRepresentation, DerivedUnit>();
    }

    /// <summary>
    /// Tries to get the unit.
    /// </summary>
    /// <param name="flatRepresentation">The flat representation.</param>
    /// <param name="derivedUnit">The found derived unit.</param>
    /// <returns>
    ///   <c>true</c> if the flat representation is found, otherwise <c>false</c>
    /// </returns>
    public bool TryGetUnit(FlatRepresentation flatRepresentation, out DerivedUnit derivedUnit)
    {
        return this.derivedUnits.TryGetValue(flatRepresentation, out derivedUnit);
    }

    /// <summary>
    /// Tries to get the prefix.
    /// </summary>
    /// <param name="prefixFactor">The prefix factor.</param>
    /// <param name="prefix">The found prefix.</param>
    /// <returns>
    ///   <c>true</c> if the prefix factor is found, otherwise <c>false</c>
    /// </returns>
    public bool TryGetPrefix(double prefixFactor, out Prefix prefix)
    {
        return this.prefixValueDefinitions.TryGetValue(prefixFactor, out prefix);
    }

    /// <summary>
    /// Registers the unit.
    /// </summary>
    /// <param name="unit">
    /// The unit to be registered.
    /// </param>
    public void Register(IUnit unit)
    {
        this.unitDefinitions.Add(unit.GetNotationWithoutPrefix(), unit);
    }

    /// <summary>
    /// Unregisters the unit.
    /// </summary>
    /// <param name="unit">
    /// The unit to be unregistered.
    /// </param>
    public void Unregister(IUnit unit)
    {
        this.unitDefinitions.Remove(unit.GetNotationWithoutPrefix());
    }

    /// <summary>
    /// Registers the unit.
    /// </summary>
    /// <param name="derivedUnit">
    /// The unit to be registered.
    /// </param>
    public void Register(DerivedUnit derivedUnit)
    {
        var derivedNotation = derivedUnit.Notation;
        this.unitDefinitions.Add(derivedNotation, derivedUnit);
        var expression = derivedUnit.GetBaseExpression();
        var flatRepresentation = this.expressionToFlatRepresentationConverter.Convert(
            expression,
            false,
            new FlatRepresentationBuilder());
        this.derivedUnits.Add(flatRepresentation, derivedUnit);
    }

    /// <summary>
    /// Unregisters the unit.
    /// </summary>
    /// <param name="derivedUnit">
    /// The unit to be unregistered.
    /// </param>
    public void Unregister(DerivedUnit derivedUnit)
    {
        this.unitDefinitions.Remove(derivedUnit.Notation);

        var baseExpression = derivedUnit.GetBaseExpression();
        var flatRepresentation = this.expressionToFlatRepresentationConverter.Convert(
            baseExpression,
            false,
            new FlatRepresentationBuilder());
        this.derivedUnits.Remove(flatRepresentation);
    }

    /// <summary>
    /// Registers the prefix.
    /// </summary>
    /// <param name="prefix">
    /// The prefix.
    /// </param>
    public void Register(Prefix prefix)
    {
        this.prefixDefinitions.Add(prefix.Notation, prefix);
        this.prefixValueDefinitions.Add(prefix.Factor, prefix);
    }

    /// <summary>
    /// Unregisters the prefix.
    /// </summary>
    /// <param name="prefix">
    /// The prefix.
    /// </param>
    public void Unregister(Prefix prefix)
    {
        this.prefixDefinitions.Remove(prefix.Notation);
        this.prefixValueDefinitions.Remove(prefix.Factor);
    }

    /// <summary>
    /// Gets the units.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{IUnit}" />.
    /// </returns>
    public IEnumerable<IUnit> GetUnits()
    {
        return this.unitDefinitions.Values;
    }

    /// <summary>
    /// Gets the prefixes.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{Prefix}" />.
    /// </returns>
    public IEnumerable<Prefix> GetPrefixes()
    {
        return this.prefixDefinitions.Values;
    }

    /// <summary>
    /// Gets the unit notations.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{String}" />.
    /// </returns>
    public IEnumerable<string> GetUnitNotations()
    {
        return this.unitDefinitions.Keys;
    }

    /// <summary>
    /// Gets the prefix notations.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{String}" />.
    /// </returns>
    public IEnumerable<string> GetPrefixNotations()
    {
        return this.prefixDefinitions.Values.Select(x => x.Notation);
    }

    /// <summary>
    /// Tries to get the unit.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="unit">The found unit.</param>
    /// <returns><c>true</c> if the input is found, otherwise <c>false</c> </returns>
    public bool TryGet(string input, out IUnit unit)
    {
        return this.unitDefinitions.TryGetValue(input, out unit);
    }

    /// <summary>
    /// Tries to get the prefix.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="prefix">The prefix.</param>
    /// <returns><c>true</c> if the input is found, otherwise <c>false</c> </returns>
    public bool TryGet(string input, out Prefix prefix)
    {
        return this.prefixDefinitions.TryGetValue(input, out prefix);
    }

    /// <summary>
    /// Resets this instance.
    /// </summary>
    public void Reset()
    {
        this.unitDefinitions.Clear();
        this.prefixDefinitions.Clear();
        this.prefixValueDefinitions.Clear();
        this.derivedUnits.Clear();
    }
}