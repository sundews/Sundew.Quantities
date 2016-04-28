namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using System;

    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Prefix visitor for converting an <see cref="Expression"/> to its prefix value.
    /// </summary>
    public class PrefixVisitor : IExpressionVisitor<double, Reference<double>, double>
    {
        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        /// <returns>The resulting prefix.</returns>
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
        public void Multiply(MultiplicationExpression multiplicationExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = this.Visit(multiplicationExpression.Lhs) / this.Visit(multiplicationExpression.Rhs);
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Divide(DivisionExpression divisionExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = this.Visit(divisionExpression.Lhs) / this.Visit(divisionExpression.Rhs);
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Magnitude(MagnitudeExpression magnitudeExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = Math.Pow(this.Visit(magnitudeExpression.Lhs), magnitudeExpression.Rhs.Constant);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Parenthesis(ParenthesisExpression parenthesisExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = this.Visit(parenthesisExpression.Expression);
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Unit(UnitExpression unitExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = unitExpression.Unit.PrefixFactor;
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Variable(VariableExpression variableExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = 1;
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="value">The value.</param>
        /// <param name="currentResult">The current result.</param>
        public void Constant(ConstantExpression constantExpression, double value, Reference<double> currentResult)
        {
            currentResult.Value = 1;
        }

        private double PrivateVisit(Expression expression, double value, Reference<double> currentResult)
        {
            expression.Visit(this, value, currentResult);
            return currentResult.Value;
        }
    }
}