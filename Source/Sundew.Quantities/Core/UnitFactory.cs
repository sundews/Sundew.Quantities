// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitFactory.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

using Sundew.Quantities.Representations.Evaluation;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;
using Sundew.Quantities.Representations.Units;

/// <summary>
/// Default implementation of <see cref="IUnitFactory"/>.
/// </summary>
public class UnitFactory : IUnitFactory
{
    private readonly IDerivedUnitRegistry derivedUnitRegistry;

    private readonly IExpressionRewriter expressionRewriter;

    private readonly IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitFactory" /> class.
    /// </summary>
    /// <param name="expressionToFlatRepresentationConverter">The expression to flat representation converter.</param>
    /// <param name="expressionRewriter">The expression rewriter.</param>
    /// <param name="derivedUnitRegistry">The derived unit registry.</param>
    public UnitFactory(
        IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter,
        IExpressionRewriter expressionRewriter,
        IDerivedUnitRegistry derivedUnitRegistry)
    {
        this.expressionToFlatRepresentationConverter = expressionToFlatRepresentationConverter;
        this.expressionRewriter = expressionRewriter;
        this.derivedUnitRegistry = derivedUnitRegistry;
    }

    /// <summary>
    /// Creates an unit for the specified expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <returns>A new <see cref="IUnit"/>.</returns>
    public IUnit Create(Expression expression)
    {
        return expression is UnitExpression unitExpression ? unitExpression.Unit : this.CreateDerivedUnit(expression);
    }

    /// <summary>
    /// Creates the derived unit from the specified expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <returns>A new <see cref="DerivedUnit"/>.</returns>
    public DerivedUnit CreateDerivedUnit(Expression expression)
    {
        var flatRepresentation = this.expressionToFlatRepresentationConverter.Convert(
            expression,
            false,
            new FlatRepresentationBuilder());
        var reductionResult = new ReductionResult(flatRepresentation, expression, false);
        return this.CreateDerivedUnit(reductionResult);
    }

    /// <summary>
    /// Creates the specified reduction result.
    /// </summary>
    /// <param name="reductionResult">The reduction result.</param>
    /// <returns>A new  <see cref="IUnit"/> for the <see cref="IReductionResult"/>.</returns>
    public IUnit Create(IReductionResult reductionResult)
    {
        return this.CreateDerivedUnit(reductionResult);
    }

    /// <summary>
    /// Creates the derived unit.
    /// </summary>
    /// <param name="reductionResult">The reduction result.</param>
    /// <returns>A new <see cref="DerivedUnit" />.</returns>
    public DerivedUnit CreateDerivedUnit(IReductionResult reductionResult)
    {
        return this.CreateDerivedUnit(reductionResult, reductionResult);
    }

    /// <summary>
    /// Creates the derived unit.
    /// </summary>
    /// <param name="baseReductionResult">The base reduction result.</param>
    /// <param name="reductionResult">The reduction result.</param>
    /// <returns>A new <see cref="DerivedUnit" /> for the <see cref="IReductionResult" />.</returns>
    public DerivedUnit CreateDerivedUnit(IReductionResult baseReductionResult, IReductionResult reductionResult)
    {
        if (this.derivedUnitRegistry.TryGetUnit(baseReductionResult.FlatRepresentation, out var derivedUnit))
        {
            return derivedUnit;
        }

        var expression = reductionResult.GetReducedExpression(this.expressionRewriter);
        if (expression is UnitExpression unitExpression)
        {
            derivedUnit = unitExpression.Unit as DerivedUnit;
            if (derivedUnit != null)
            {
                return derivedUnit;
            }
        }

        return new DerivedUnit(null, expression);
    }

    /// <summary>
    /// Creates the prefixed unit.
    /// </summary>
    /// <param name="unit">The quantity unit.</param>
    /// <param name="prefixFactor">The prefix factor.</param>
    /// <returns>A new <see cref="IUnit"/>.</returns>
    public IUnit CreatePrefixedUnit(IUnit unit, double prefixFactor)
    {
        if (this.derivedUnitRegistry.TryGetPrefix(prefixFactor, out var prefix))
        {
            return unit.GetPrefixedUnit(prefix);
        }

        return unit;
    }
}