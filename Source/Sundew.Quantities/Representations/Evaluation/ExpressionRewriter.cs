// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionRewriter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using System;
    using System.Collections.Generic;
    using Sundew.Base.Primitives.Visiting;
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Implements <see cref="IExpressionRewriter"/> for rewriting <see cref="Expression"/>s.
    /// </summary>
    public partial class ExpressionRewriter : IExpressionRewriter, IExpressionVisitor<RewritingParameters, Reference<Expression>, Expression>
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
            return this.Visit(expression, new RewritingParameters(reduceByBaseUnit, flatRepresentationConsumer));
        }

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>
        /// The rewritten <see cref="Expression" />.
        /// </returns>
        public Expression Visit(
            Expression expression,
            RewritingParameters rewritingParameters = null,
            Reference<Expression> currentResult = null)
        {
            rewritingParameters ??= new RewritingParameters(false, new FlatRepresentationConsumer(new Dictionary<string, IFlatIdentifierRepresentation>()));
            currentResult ??= new Reference<Expression>(expression);
            expression.Visit(this, rewritingParameters, currentResult);
            var result = currentResult.Value;
            if (result == null)
            {
                return ConstantExpression.One;
            }

            return result;
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression" />.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            multiplicationExpression.Lhs.Visit(this, rewritingParameters, currentResult);
            var lhs = currentResult.Value;
            multiplicationExpression.Rhs.Visit(this, rewritingParameters, currentResult);
            var rhs = currentResult.Value;
            currentResult.Value = this.SelectCurrentExpression(
                multiplicationExpression,
                lhs,
                rhs,
                (newLhs, newRhs) => new MultiplicationExpression(newLhs, newRhs));
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression" />.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Divide(
            DivisionExpression divisionExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            divisionExpression.Lhs.Visit(this, rewritingParameters, currentResult);
            var lhs = currentResult.Value;
            divisionExpression.Rhs.Visit(this, rewritingParameters, currentResult);
            var rhs = currentResult.Value;
            currentResult.Value = this.SelectCurrentExpression(
                divisionExpression,
                lhs,
                rhs,
                (newLhs, newRhs) => new DivisionExpression(newLhs, newRhs));
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression" />.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Magnitude(
            MagnitudeExpression magnitudeExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            magnitudeExpression.Lhs.Visit(this, rewritingParameters, currentResult);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression" />.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            parenthesisExpression.Expression.Visit(this, rewritingParameters, currentResult);
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
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Unit(
            UnitExpression unitExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            currentResult.Value = rewritingParameters.FlatRepresentationConsumer.GetResultingExpression(unitExpression, rewritingParameters.ReduceByBaseUnit);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression" />.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Variable(
            VariableExpression variableExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            currentResult.Value = rewritingParameters.FlatRepresentationConsumer.GetResultingExpression(variableExpression);
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression" />.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void Constant(
            ConstantExpression constantExpression,
            RewritingParameters rewritingParameters,
            Reference<Expression> currentResult)
        {
            currentResult.Value = rewritingParameters.FlatRepresentationConsumer.GetResultingExpression(constantExpression);
        }

        /// <summary>
        /// Visits the unknown.
        /// </summary>
        /// <param name="expresstion">The expresstion.</param>
        /// <param name="rewritingParameters">The rewriting parameters.</param>
        /// <param name="currentResult">The current result.</param>
        public void VisitUnknown(Expression expresstion, RewritingParameters rewritingParameters = null, Reference<Expression> currentResult = null)
        {
            throw VisitException.Create(expresstion, rewritingParameters, currentResult);
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

            return operandChange switch
            {
                OperandChange.LhsIsNull => newRhs,
                OperandChange.RhsIsNull => newLhs,
                OperandChange.BothAreNull => null,
                _ => bothHaveChangedFactory(newLhs, newRhs)
            };
        }
    }
}