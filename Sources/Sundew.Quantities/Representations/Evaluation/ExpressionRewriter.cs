// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionRewriter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using System;
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Implements <see cref="IExpressionRewriter"/> for rewriting <see cref="Expression"/>s.
    /// </summary>
    public partial class ExpressionRewriter : IExpressionRewriter,
                                              IExpressionVisitor
                                                  <bool, FlatRepresentationConsumer, Reference<Expression>, Expression>
    {
        /// <summary>
        /// Rewrites the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <returns>
        /// The rewritten <see cref="Expression" />.
        /// </returns>
        public Expression Rewrite(
            Expression expression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer)
        {
            return this.Visit(expression, reduceByBaseUnit, flatRepresentationConsumer);
        }

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>The rewritten <see cref="Expression"/>.</returns>
        public Expression Visit(
            Expression expression,
            bool reduceByBaseUnit = false,
            FlatRepresentationConsumer flatRepresentationConsumer = null,
            Reference<Expression> currentResult = null)
        {
            currentResult = currentResult ?? new Reference<Expression>(expression);
            expression.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
            var result = currentResult.Value;
            if (result == null)
            {
                return ConstantExpression.One;
            }

            return result;
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            multiplicationExpression.Lhs.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
            var lhs = currentResult.Value;
            multiplicationExpression.Rhs.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
            var rhs = currentResult.Value;
            currentResult.Value = this.SelectCurrentExpression(
                multiplicationExpression,
                lhs,
                rhs,
                (newLhs, newRhs) => new MultiplicationExpression(newLhs, newRhs));
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Divide(
            DivisionExpression divisionExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            divisionExpression.Lhs.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
            var lhs = currentResult.Value;
            divisionExpression.Rhs.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
            var rhs = currentResult.Value;
            currentResult.Value = this.SelectCurrentExpression(
                divisionExpression,
                lhs,
                rhs,
                (newLhs, newRhs) => new DivisionExpression(newLhs, newRhs));
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Magnitude(
            MagnitudeExpression magnitudeExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            magnitudeExpression.Lhs.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            parenthesisExpression.Expression.Visit(this, reduceByBaseUnit, flatRepresentationConsumer, currentResult);
            if (ReferenceEquals(parenthesisExpression.Expression, currentResult.Value))
            {
                currentResult.Value = parenthesisExpression;
            }
            else
            {
                currentResult.Value = new ParenthesisExpression(currentResult.Value);
            }
        }

        /// <summary>
        /// Units the specified unit expression.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Unit(
            UnitExpression unitExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            currentResult.Value = flatRepresentationConsumer.GetResultingExpression(unitExpression, reduceByBaseUnit);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Variable(
            VariableExpression variableExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            currentResult.Value = flatRepresentationConsumer.GetResultingExpression(variableExpression);
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <param name="currentResult">The current result.</param>
        public void Constant(
            ConstantExpression constantExpression,
            bool reduceByBaseUnit,
            FlatRepresentationConsumer flatRepresentationConsumer,
            Reference<Expression> currentResult)
        {
            currentResult.Value = flatRepresentationConsumer.GetResultingExpression(constantExpression);
        }

        private Expression SelectCurrentExpression<TExpression>(
            TExpression originalExpression,
            Expression newLhs,
            Expression newRhs,
            Func<Expression, Expression, Expression> bothHaveChangedFactory)
            where TExpression : Expression, IHaveLhsAndRhs<Expression>
        {
            if (ReferenceEquals(originalExpression.Lhs, newLhs) && ReferenceEquals(originalExpression.Rhs, newRhs))
            {
                return originalExpression;
            }

            var operandChange = OperandChange.NoChange;
            if (newLhs == null)
            {
                operandChange |= OperandChange.LhsIsNull;
            }

            if (newRhs == null)
            {
                operandChange |= OperandChange.RhsIsNull;
            }

            switch (operandChange)
            {
                case OperandChange.LhsIsNull:
                    return newRhs;
                case OperandChange.RhsIsNull:
                    return newLhs;
                case OperandChange.BothAreNull:
                    return null;
                default:
                    return bothHaveChangedFactory(newLhs, newRhs);
            }
        }
    }
}