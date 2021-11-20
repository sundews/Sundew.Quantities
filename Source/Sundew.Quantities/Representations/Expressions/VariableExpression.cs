// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariableExpression.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions;

using System;

/// <summary>
/// Represents a variable.
/// </summary>
public sealed class VariableExpression : Expression, IEquatable<VariableExpression>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VariableExpression"/> class.
    /// </summary>
    /// <param name="variableName">Name of the variable.</param>
    public VariableExpression(string variableName)
    {
        this.VariableName = variableName;
    }

    /// <summary>
    /// Gets the name of the variable.
    /// </summary>
    /// <value>
    /// The name of the variable.
    /// </value>
    public string VariableName { get; }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    ///     <c>true</c> if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
    /// </returns>
    public bool Equals(VariableExpression other)
    {
        return this.VariableName.Equals(other.VariableName);
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
        expressionVisitor.Variable(this, parameter1, parameter2);
    }
}