// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExpression.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions;

using System;

/// <summary>
/// Represents a unit.
/// </summary>
public sealed class UnitExpression : Expression, IEquatable<UnitExpression>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitExpression" /> class.
    /// </summary>
    /// <param name="unit">The quantity unit.</param>
    public UnitExpression(IUnit unit)
    {
        this.Unit = unit;
    }

    /// <summary>
    /// Gets the unit.
    /// </summary>
    /// <value>
    /// The quantity unit.
    /// </value>
    public IUnit Unit { get; }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    ///     <c>true</c> if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
    /// </returns>
    public bool Equals(UnitExpression other)
    {
        return UnitEqualityHelper.AreUnitsEqual(this.Unit, other.Unit);
    }

    /// <summary>
    /// Visits the specified expression visitor.
    /// </summary>
    /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
    /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <param name="expressionVisitor">The expression visitor.</param>
    /// <param name="parameter1">The parameter1.</param>
    /// <param name="parameter2">The parameter2.</param>
    public override void Visit<TParameter1, TParameter2, TResult>(
        IExpressionVisitor<TParameter1, TParameter2, TResult> expressionVisitor,
        TParameter1 parameter1,
        TParameter2 parameter2)
    {
        expressionVisitor.Unit(this, parameter1, parameter2);
    }
}