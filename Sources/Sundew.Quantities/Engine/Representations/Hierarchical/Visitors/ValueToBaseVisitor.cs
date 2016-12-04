// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValueToBaseVisitor.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using System;

    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Converts a unit value into the base <see cref="Expression"/> unit value.
    /// </summary>
    public class ValueToBaseVisitor : IExpressionVisitor<double, Reference<double>, double>
    {
        private const double Zero = 0.0;

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>The base <see cref="Expression"/> value.</returns>
        public double Visit(Expression expression, double value = 0, Reference<double> currentResult = null)
        {
            currentResult = currentResult ?? new Reference<double>(0);
            return this.PrivateVisit(expression, value, currentResult);
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            double value,
            Reference<double> currentResult)
        {
            var lhs = this.PrivateVisit(multiplicationExpression.Lhs, value, currentResult);
            if (lhs.Equals(Zero))
            {
                currentResult.Value = Zero;
                return;
            }

            var rhs = this.PrivateVisit(multiplicationExpression.Rhs, value, currentResult);
            if (rhs.Equals(Zero))
            {
                currentResult.Value = Zero;
                return;
            }

            currentResult.Value = lhs * rhs / value;
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Divide(DivisionExpression divisionExpression, double value, Reference<double> currentResult)
        {
            var lhs = this.PrivateVisit(divisionExpression.Lhs, value, currentResult);
            if (lhs.Equals(Zero))
            {
                currentResult.Value = Zero;
                return;
            }

            var rhs = this.PrivateVisit(divisionExpression.Rhs, value, currentResult);
            currentResult.Value = lhs / rhs * value;
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Magnitude(MagnitudeExpression magnitudeExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = value
                                  * Math.Pow(
                                      this.PrivateVisit(magnitudeExpression.Lhs, 1, currentResult),
                                      magnitudeExpression.Rhs.Constant);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            double value,
            Reference<double> currentResult)
        {
            currentResult.Value = this.PrivateVisit(parenthesisExpression.Expression, value, currentResult);
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Unit(UnitExpression unitExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = unitExpression.Unit.ToBase(value);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Variable(VariableExpression variableExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = value;
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Constant(ConstantExpression constantExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = value / constantExpression.Constant;
        }

        private double PrivateVisit(Expression expression, double value, Reference<double> currentResult)
        {
            expression.Visit(this, value, currentResult);
            return currentResult.Value;
        }
    }
}