namespace Sundew.Quantities.Engine.Representations.Conversion
{
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;

    /// <summary>
    /// Converts <see cref="Expression"/> into <see cref="FlatRepresentation"/>.
    /// </summary>
    public class ExpressionToFlatRepresentationConverter : IExpressionToFlatRepresentationConverter, IExpressionVisitor<bool, double, bool, FlatRepresentationBuilder, FlatRepresentation>
    {
        /// <summary>
        /// Converts the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        /// <returns>A <see cref="FlatRepresentation"/>.</returns>
        public FlatRepresentation Convert(Expression expression, bool reduceUsingBaseUnits, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            return this.Visit(expression, reduceUsingBaseUnits, 0.0, false, flatRepresentationBuilder);
        }

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        /// <returns>A <see cref="FlatRepresentation"/>.</returns>
        public FlatRepresentation Visit(Expression expression, bool reduceUsingBaseUnits = false, double exponent = 0.0, bool expressionIsPartOfDenominator = false, FlatRepresentationBuilder flatRepresentationBuilder = null)
        {
            flatRepresentationBuilder = flatRepresentationBuilder ?? new FlatRepresentationBuilder();
            exponent = exponent.Equals(0.0) ? 1 : exponent;
            expression.Visit(this, reduceUsingBaseUnits, exponent, expressionIsPartOfDenominator, flatRepresentationBuilder);
            return flatRepresentationBuilder.Build();
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Multiply(MultiplicationExpression multiplicationExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            multiplicationExpression.Lhs.Visit(this, reduceUsingBaseUnits, exponent, expressionIsPartOfDenominator, flatRepresentationBuilder);
            multiplicationExpression.Rhs.Visit(this, reduceUsingBaseUnits, exponent, expressionIsPartOfDenominator, flatRepresentationBuilder);
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Divide(DivisionExpression divisionExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            divisionExpression.Lhs.Visit(this, reduceUsingBaseUnits, exponent, expressionIsPartOfDenominator, flatRepresentationBuilder);
            divisionExpression.Rhs.Visit(this, reduceUsingBaseUnits, exponent * -1, true, flatRepresentationBuilder);
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Magnitude(MagnitudeExpression magnitudeExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            magnitudeExpression.Lhs.Visit(this, reduceUsingBaseUnits, exponent * magnitudeExpression.Rhs.Constant, expressionIsPartOfDenominator, flatRepresentationBuilder);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parenthesis expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Parenthesis(ParenthesisExpression parenthesisExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            parenthesisExpression.Expression.Visit(this, reduceUsingBaseUnits, exponent, expressionIsPartOfDenominator, flatRepresentationBuilder);
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Unit(UnitExpression unitExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            flatRepresentationBuilder.Add(unitExpression, reduceUsingBaseUnits, exponent);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Variable(VariableExpression variableExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            flatRepresentationBuilder.Add(variableExpression, exponent);
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="exponent">The exponent.</param>
        /// <param name="expressionIsPartOfDenominator">If set to <c>true</c> the expression is part of the denominator.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public void Constant(ConstantExpression constantExpression, bool reduceUsingBaseUnits, double exponent, bool expressionIsPartOfDenominator, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            flatRepresentationBuilder.Add(constantExpression, exponent);
        }
    }
}