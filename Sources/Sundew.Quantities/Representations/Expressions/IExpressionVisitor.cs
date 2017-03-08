// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExpressionVisitor.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions
{
    using Sundew.Base.Visiting;

    /// <summary>
    /// Interface for implementing the an expression visitor with two parameters.
    /// </summary>
    /// <typeparam name="TImmutableParameter">The type of the immutable parameter.</typeparam>
    /// <typeparam name="TMutableParameter">The type of the mutable parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IExpressionVisitor<in TImmutableParameter, in TMutableParameter, out TResult> :
        IVisitor<Expression, TImmutableParameter, TMutableParameter, TResult>
    {
        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Multiply(MultiplicationExpression multiplicationExpression, TImmutableParameter parameter1, TMutableParameter parameter2);

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Divide(DivisionExpression divisionExpression, TImmutableParameter parameter1, TMutableParameter parameter2);

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Magnitude(MagnitudeExpression magnitudeExpression, TImmutableParameter parameter1, TMutableParameter parameter2);

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Parenthesis(ParenthesisExpression parenthesisExpression, TImmutableParameter parameter1, TMutableParameter parameter2);

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Unit(UnitExpression unitExpression, TImmutableParameter parameter1, TMutableParameter parameter2);

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Variable(VariableExpression variableExpression, TImmutableParameter parameter1, TMutableParameter parameter2);

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        void Constant(ConstantExpression constantExpression, TImmutableParameter parameter1, TMutableParameter parameter2);
    }
}