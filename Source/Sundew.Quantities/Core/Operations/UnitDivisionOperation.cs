// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitDivisionOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core.Operations;

using Sundew.Quantities.Representations.Evaluation;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Operation for dividing two <see cref="IUnit"/>s.
/// </summary>
public class UnitDivisionOperation : IUnitOperation<UnitReductionResult>
{
    private readonly IExpressionReducer expressionReducer;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitDivisionOperation"/> class.
    /// </summary>
    /// <param name="expressionReducer">The expression reducer.</param>
    public UnitDivisionOperation(IExpressionReducer expressionReducer)
    {
        this.expressionReducer = expressionReducer;
    }

    /// <summary>
    /// Executes the specified LHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <param name="reduceByBaseUnits">If set to <c>true</c> reduction will be done with base units.</param>
    /// <returns>A <see cref="UnitReductionResult"/>.</returns>
    public UnitReductionResult Execute(IUnit lhs, IUnit rhs, bool reduceByBaseUnits)
    {
        return this.expressionReducer.Reduce(
            new DivisionExpression(lhs.GetExpression(), rhs.GetExpression()),
            reduceByBaseUnits);
    }
}