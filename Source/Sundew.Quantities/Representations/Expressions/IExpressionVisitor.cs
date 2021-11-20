// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExpressionVisitor.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions;

using Sundew.Base.Primitives.Visiting;

/// <summary>
/// Interface for implementing the an expression visitor with two parameters.
/// </summary>
/// <typeparam name="TParameter">The type of the immutable parameter.</typeparam>
/// <typeparam name="TVariable">The type of the mutable parameter.</typeparam>
/// <typeparam name="TResult">The type of the result.</typeparam>
public interface IExpressionVisitor<in TParameter, in TVariable, out TResult> :
    IVisitor<Expression, TParameter, TVariable, TResult>
{
    /// <summary>
    /// Visits a <see cref="MultiplicationExpression"/>.
    /// </summary>
    /// <param name="multiplicationExpression">The multiplication expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Multiply(MultiplicationExpression multiplicationExpression, TParameter parameter, TVariable variable);

    /// <summary>
    /// Visits a <see cref="DivisionExpression"/>.
    /// </summary>
    /// <param name="divisionExpression">The division expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Divide(DivisionExpression divisionExpression, TParameter parameter, TVariable variable);

    /// <summary>
    /// Visits a <see cref="MagnitudeExpression"/>.
    /// </summary>
    /// <param name="magnitudeExpression">The magnitude expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Magnitude(MagnitudeExpression magnitudeExpression, TParameter parameter, TVariable variable);

    /// <summary>
    /// Visits a <see cref="ParenthesisExpression"/>.
    /// </summary>
    /// <param name="parenthesisExpression">The parentheses expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Parenthesis(ParenthesisExpression parenthesisExpression, TParameter parameter, TVariable variable);

    /// <summary>
    /// Visits a <see cref="UnitExpression"/>.
    /// </summary>
    /// <param name="unitExpression">The unit expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Unit(UnitExpression unitExpression, TParameter parameter, TVariable variable);

    /// <summary>
    /// Visits a <see cref="VariableExpression"/>.
    /// </summary>
    /// <param name="variableExpression">The variable expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Variable(VariableExpression variableExpression, TParameter parameter, TVariable variable);

    /// <summary>
    /// Visits a <see cref="ConstantExpression"/>.
    /// </summary>
    /// <param name="constantExpression">The constant expression.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="variable">The variable.</param>
    void Constant(ConstantExpression constantExpression, TParameter parameter, TVariable variable);
}