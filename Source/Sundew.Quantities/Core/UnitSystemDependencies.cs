// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitSystemDependencies.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

using Sundew.Quantities.Core.Operations;
using Sundew.Quantities.Parsing;
using Sundew.Quantities.Parsing.LexicalAnalysis;
using Sundew.Quantities.Registration;

/// <summary>
/// Contains dependencies for the <see cref="UnitSystem"/>.
/// </summary>
public class UnitSystemDependencies
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitSystemDependencies"/> class.
    /// </summary>
    /// <param name="unitRegistry">The unit registry.</param>
    /// <param name="lexicalAnalyzer">The lexical analyzer.</param>
    /// <param name="expressionParser">The expression parser.</param>
    /// <param name="quantityParser">The quantity parser.</param>
    /// <param name="unitFactory">The unit factory.</param>
    /// <param name="quantityOperations">The quantity operations.</param>
    public UnitSystemDependencies(
        UnitRegistry unitRegistry,
        ILexicalAnalyzer lexicalAnalyzer,
        IExpressionParser expressionParser,
        IQuantityParser quantityParser,
        IUnitFactory unitFactory,
        IQuantityOperations quantityOperations)
    {
        this.UnitRegistry = unitRegistry;
        this.LexicalAnalyzer = lexicalAnalyzer;
        this.ExpressionParser = expressionParser;
        this.QuantityParser = quantityParser;
        this.UnitFactory = unitFactory;
        this.QuantityOperations = quantityOperations;
    }

    /// <summary>
    /// Gets the unit registry.
    /// </summary>
    /// <value>
    /// The unit registry.
    /// </value>
    public UnitRegistry UnitRegistry { get; }

    /// <summary>
    /// Gets the lexical analyzer.
    /// </summary>
    /// <value>
    /// The lexical analyzer.
    /// </value>
    public ILexicalAnalyzer LexicalAnalyzer { get; }

    /// <summary>
    /// Gets the expression parser.
    /// </summary>
    /// <value>
    /// The expression parser.
    /// </value>
    public IExpressionParser ExpressionParser { get; }

    /// <summary>
    /// Gets the quantity parser.
    /// </summary>
    /// <value>
    /// The quantity parser.
    /// </value>
    public IQuantityParser QuantityParser { get; }

    /// <summary>
    /// Gets the unit factory.
    /// </summary>
    /// <value>
    /// The unit factory.
    /// </value>
    public IUnitFactory UnitFactory { get; }

    /// <summary>
    /// Gets the quantity operations.
    /// </summary>
    /// <value>
    /// The quantity operations.
    /// </value>
    public IQuantityOperations QuantityOperations { get; }
}