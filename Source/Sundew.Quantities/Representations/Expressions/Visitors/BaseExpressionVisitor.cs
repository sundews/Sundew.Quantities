// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseExpressionVisitor.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors
{
    using Sundew.Base.Primitives;
    using Sundew.Base.Primitives.Visiting;
    using Sundew.Base.Visiting;

    /// <summary>
    /// Base expression visitor for converting <see cref="Expression"/>s to its base <see cref="Expression"/>.
    /// </summary>
    public class BaseExpressionVisitor : IExpressionVisitor<ˍ, Reference<Expression>, Expression>
    {
        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The exponential notation.</param>
        /// <param name="_">The _.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>
        /// The base <see cref="Expression" />.
        /// </returns>
        public Expression Visit(Expression expression, ˍ _ = default, Reference<Expression> currentResult = null)
        {
            currentResult = currentResult ?? new Reference<Expression>(expression);
            return this.PrivateVisit(expression, currentResult);
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression" />.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Multiply(MultiplicationExpression multiplicationExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value =
                new MultiplicationExpression(
                    this.PrivateVisit(multiplicationExpression.Lhs, currentResult),
                    this.PrivateVisit(multiplicationExpression.Rhs, currentResult));
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression" />.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Divide(DivisionExpression divisionExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value = new DivisionExpression(
                this.PrivateVisit(divisionExpression.Lhs, currentResult),
                this.PrivateVisit(divisionExpression.Rhs, currentResult));
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression" />.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Magnitude(MagnitudeExpression magnitudeExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value = new MagnitudeExpression(
                this.PrivateVisit(magnitudeExpression.Lhs, currentResult),
                magnitudeExpression.Rhs);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression" />.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Parenthesis(ParenthesisExpression parenthesisExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value =
                new ParenthesisExpression(this.PrivateVisit(parenthesisExpression.Expression, currentResult));
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression" />.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Unit(UnitExpression unitExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value = unitExpression.Unit.BaseUnit.GetExpression();
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression" />.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Variable(VariableExpression variableExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value = variableExpression;
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression" />.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void Constant(ConstantExpression constantExpression, ˍ _, Reference<Expression> currentResult)
        {
            currentResult.Value = constantExpression;
        }

        /// <summary>
        /// Visits the unknown.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="_">The ignored.</param>
        /// <param name="currentResult">The current result.</param>
        public void VisitUnknown(Expression expression, ˍ _, Reference<Expression> currentResult)
        {
            throw VisitException.Create(expression, _, currentResult);
        }

        /// <summary>
        /// Privates the visit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>The base expression.</returns>
        private Expression PrivateVisit(Expression expression, Reference<Expression> currentResult)
        {
            expression.Visit(this, ˍ._, currentResult);
            return currentResult.Value;
        }
    }
}