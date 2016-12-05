// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Expression.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions
{
    using Sundew.Quantities.Representations.Expressions.Visitors;

    /// <summary>
    /// Base class for implementing expressions.
    /// </summary>
    public abstract class Expression
    {
        /// <summary>
        /// Creates an <see cref="MultiplicationExpression"/> with the specified lhs and rhs.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="Expression"/>.</param>
        /// <param name="rhs">The RHS <see cref="Expression"/>.</param>
        /// <returns>An <see cref="MultiplicationExpression"/>.</returns>
        public static MultiplicationExpression operator *(Expression lhs, Expression rhs)
        {
            return new MultiplicationExpression(lhs, rhs);
        }

        /// <summary>
        /// Creates an <see cref="DivisionExpression"/> with the specified lhs and rhs.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="Expression"/>.</param>
        /// <param name="rhs">The RHS <see cref="Expression"/>.</param>
        /// <returns>An <see cref="DivisionExpression"/>.</returns>
        public static DivisionExpression operator /(Expression lhs, Expression rhs)
        {
            return new DivisionExpression(lhs, rhs);
        }

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter">The type of the parameter.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter">The parameter.</param>
        public abstract void Visit<TParameter, TResult>(
            IExpressionVisitor<TParameter, TResult> expressionVisitor,
            TParameter parameter);

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        public abstract void Visit<TParameter1, TParameter2, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2);

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TParameter3">The type of the parameter3.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        public abstract void Visit<TParameter1, TParameter2, TParameter3, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TParameter3, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2,
            TParameter3 parameter3);

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TParameter3">The type of the parameter3.</typeparam>
        /// <typeparam name="TParameter4">The type of the parameter4.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        public abstract void Visit<TParameter1, TParameter2, TParameter3, TParameter4, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TParameter3, TParameter4, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2,
            TParameter3 parameter3,
            TParameter4 parameter4);

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return DefaultVisitors.NotationVisitor.Visit(this);
        }
    }
}