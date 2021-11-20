﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitSystemDependencyFactory.cs" company="Hukano">
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
using Sundew.Quantities.Representations.Expressions.Visitors;

/// <summary>
/// Default implementation for <see cref="IUnitSystemDependencyFactory"/>.
/// </summary>
public class UnitSystemDependencyFactory : IUnitSystemDependencyFactory
{
    private static readonly ValueFromBaseVisitor ValueFromBaseVisitor = DefaultVisitors.ValueFromBaseVisitor;

    private static readonly ValueToBaseVisitor ValueToBaseVisitor = DefaultVisitors.ValueToBaseVisitor;

    private readonly IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitSystemDependencyFactory"/> class.
    /// </summary>
    /// <param name="expressionToFlatRepresentationConverter">The expression to flat representation converter.</param>
    public UnitSystemDependencyFactory(
        IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter = null)
    {
        this.expressionToFlatRepresentationConverter = expressionToFlatRepresentationConverter
                                                       ?? new ExpressionToFlatRepresentationConverter();
    }

    /// <summary>
    /// Creates the expression converter.
    /// </summary>
    /// <returns>
    /// An <see cref="IExpressionToFlatRepresentationConverter" />.
    /// </returns>
    public IExpressionToFlatRepresentationConverter CreateExpressionConverter()
    {
        return this.expressionToFlatRepresentationConverter;
    }

    /// <summary>
    /// Creates the lexical analyzer.
    /// </summary>
    /// <param name="tokenMatchers">The token matchers.</param>
    /// <returns>A new <see cref="LexicalAnalyzer"/>.</returns>
    public ILexicalAnalyzer CreateLexicalAnalyzer(IEnumerable<TokenMatcher> tokenMatchers)
    {
        return new LexicalAnalyzer(tokenMatchers);
    }

    /// <summary>
    /// Creates the unit registry.
    /// </summary>
    /// <returns>
    /// An <see cref="UnitRegistry" />.
    /// </returns>
    public UnitRegistry CreateUnitRegistry()
    {
        return new UnitRegistry(this.expressionToFlatRepresentationConverter);
    }

    /// <summary>
    /// Creates the parser.
    /// </summary>
    /// <param name="unitRegistry">The unit registry.</param>
    /// <returns>
    /// A new <see cref="IExpressionParser" />.
    /// </returns>
    public IExpressionParser CreateParser(IUnitRegistry unitRegistry)
    {
        var tokenMatcherBuilder = new TokenMatcherBuilder();
        var prefixTokenMatchers = tokenMatcherBuilder.Build(unitRegistry.GetPrefixNotations(), true);
        var unitTokenMatchers = tokenMatcherBuilder.Build(unitRegistry.GetUnitNotations(), false);
        var unitExpressionParser = new UnitExpressionParser(
            unitRegistry,
            new LexicalAnalyzer(new[] { prefixTokenMatchers, unitTokenMatchers }));
        return new ExpressionParser(unitExpressionParser);
    }

    /// <summary>
    /// Creates the parser.
    /// </summary>
    /// <param name="expressionParser">The expression parser.</param>
    /// <param name="unitFactory">The unit factory.</param>
    /// <returns>
    /// A <see cref="QuantityParser" />.
    /// </returns>
    public IQuantityParser CreateParser(IExpressionParser expressionParser, IUnitFactory unitFactory)
    {
        return new QuantityParser(expressionParser, unitFactory);
    }

    /// <summary>
    /// Creates the unit factory.
    /// </summary>
    /// <param name="derivedUnitRegistry">The derived unit registry.</param>
    /// <returns>
    /// A new <see cref="IUnitFactory" />.
    /// </returns>
    public IUnitFactory CreateUnitFactory(IDerivedUnitRegistry derivedUnitRegistry)
    {
        return new UnitFactory(
            this.expressionToFlatRepresentationConverter,
            new ExpressionRewriter(),
            derivedUnitRegistry);
    }

    /// <summary>
    /// Creates the quantity operations.
    /// </summary>
    /// <param name="unitFactory">The unit factory.</param>
    /// <returns>The <see cref="IQuantityOperations"/>.</returns>
    public IQuantityOperations CreateQuantityOperations(IUnitFactory unitFactory)
    {
        return new Operations.QuantityOperations(
            unitFactory,
            new ExpressionReducer(this.expressionToFlatRepresentationConverter),
            ValueFromBaseVisitor,
            ValueToBaseVisitor);
    }
}