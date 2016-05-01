// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="BaseExpressionVisitor.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Base expression visitor for converting <see cref="Expression"/>s to its base <see cref="Expression"/>.
    /// </summary>
    public class BaseExpressionVisitor : IExpressionVisitor<Reference<Expression>, Expression>
    {
        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The exponential notation.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>The base <see cref="Expression"/>.</returns>
        public Expression Visit(Expression expression, Reference<Expression> currentResult = null)
        {
            currentResult = currentResult ?? new Reference<Expression>(expression);
            return this.PrivateVisit(expression, currentResult);
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Multiply(MultiplicationExpression multiplicationExpression, Reference<Expression> currentResult)
        {
            currentResult.Value =
                new MultiplicationExpression(
                    this.PrivateVisit(multiplicationExpression.Lhs, currentResult),
                    this.PrivateVisit(multiplicationExpression.Rhs, currentResult));
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Divide(DivisionExpression divisionExpression, Reference<Expression> currentResult)
        {
            currentResult.Value = new DivisionExpression(
                this.PrivateVisit(divisionExpression.Lhs, currentResult),
                this.PrivateVisit(divisionExpression.Rhs, currentResult));
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Magnitude(MagnitudeExpression magnitudeExpression, Reference<Expression> currentResult)
        {
            currentResult.Value = new MagnitudeExpression(
                this.PrivateVisit(magnitudeExpression.Lhs, currentResult),
                magnitudeExpression.Rhs);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Parenthesis(ParenthesisExpression parenthesisExpression, Reference<Expression> currentResult)
        {
            currentResult.Value =
                new ParenthesisExpression(this.PrivateVisit(parenthesisExpression.Expression, currentResult));
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Unit(UnitExpression unitExpression, Reference<Expression> currentResult)
        {
            currentResult.Value = unitExpression.Unit.BaseUnit.GetExpression();
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Variable(VariableExpression variableExpression, Reference<Expression> currentResult)
        {
            currentResult.Value = variableExpression;
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="currentResult">The current result.</param>
        public void Constant(ConstantExpression constantExpression, Reference<Expression> currentResult)
        {
            currentResult.Value = constantExpression;
        }

        private Expression PrivateVisit(Expression expression, Reference<Expression> currentResult)
        {
            expression.Visit(this, currentResult);
            return currentResult.Value;
        }
    }
}