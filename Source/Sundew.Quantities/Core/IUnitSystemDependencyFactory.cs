// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitSystemDependencyFactory.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

using System.Collections.Generic;
using Operations;
using Sundew.Quantities.Parsing;
using Sundew.Quantities.Parsing.LexicalAnalysis;
using Sundew.Quantities.Registration;
using Sundew.Quantities.Representations.Evaluation;

/// <summary>
/// Interface for implementing factory for unit system dependencies.
/// </summary>
public interface IUnitSystemDependencyFactory
{
    /// <summary>
    /// Creates the lexical analyzer.
    /// </summary>
    /// <param name="tokenMatchers">The token matchers.</param>
    /// <returns>A new <see cref="LexicalAnalyzer"/>.</returns>
    ILexicalAnalyzer CreateLexicalAnalyzer(IEnumerable<TokenMatcher> tokenMatchers);

    /// <summary>
    /// Creates the expression converter.
    /// </summary>
    /// <returns>An <see cref="IExpressionToFlatRepresentationConverter"/>.</returns>
    IExpressionToFlatRepresentationConverter CreateExpressionConverter();

    /// <summary>
    /// Creates the unit registry.
    /// </summary>
    /// <returns>An <see cref="UnitRegistry"/>.</returns>
    UnitRegistry CreateUnitRegistry();

    /// <summary>
    /// Creates the parser.
    /// </summary>
    /// <param name="unitRegistry">The unit registry.</param>
    /// <returns>An <see cref="IExpressionParser" />.</returns>
    IExpressionParser CreateParser(IUnitRegistry unitRegistry);

    /// <summary>
    /// Creates the unit factory.
    /// </summary>
    /// <param name="derivedUnitRegistry">The derived unit registry.</param>
    /// <returns>An <see cref="IUnitFactory" />.</returns>
    IUnitFactory CreateUnitFactory(IDerivedUnitRegistry derivedUnitRegistry);

    /// <summary>
    /// Creates the parser.
    /// </summary>
    /// <param name="expressionParser">The expression parser.</param>
    /// <param name="unitFactory">The unit factory.</param>
    /// <returns>
    /// An <see cref="IQuantityParser" />.
    /// </returns>
    IQuantityParser CreateParser(IExpressionParser expressionParser, IUnitFactory unitFactory);

    /// <summary>
    /// Creates the quantity operations.
    /// </summary>
    /// <param name="unitFactory">The unit factory.</param>
    /// <returns>An <see cref="IQuantityOperations"/>.</returns>
    IQuantityOperations CreateQuantityOperations(IUnitFactory unitFactory);
}