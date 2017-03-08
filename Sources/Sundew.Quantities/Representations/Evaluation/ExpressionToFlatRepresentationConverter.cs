// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionToFlatRepresentationConverter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Converts <see cref="Expression"/> into <see cref="FlatRepresentation"/>.
    /// </summary>
    public class ExpressionToFlatRepresentationConverter : IExpressionToFlatRepresentationConverter,
                                                           IExpressionVisitor<ConversionParameters, ConversionVariables, FlatRepresentation>
    {
        /// <summary>
        /// Converts the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        /// <returns>A <see cref="FlatRepresentation"/>.</returns>
        public FlatRepresentation Convert(
            Expression expression,
            bool reduceUsingBaseUnits,
            FlatRepresentationBuilder flatRepresentationBuilder)
        {
            return this.Visit(expression, new ConversionParameters(reduceUsingBaseUnits, flatRepresentationBuilder), new ConversionVariables());
        }

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        /// <returns>
        /// A <see cref="FlatRepresentation" />.
        /// </returns>
        public FlatRepresentation Visit(
            Expression expression,
            ConversionParameters conversionParameters = null,
            ConversionVariables conversionVariables = null)
        {
            conversionParameters = conversionParameters ?? new ConversionParameters(false, new FlatRepresentationBuilder());
            conversionVariables = conversionVariables ?? new ConversionVariables();
            expression.Visit(this, conversionParameters, conversionVariables);
            return conversionParameters.FlatRepresentationBuilder.Build();
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression" />.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            ConversionParameters conversionParameters,
            ConversionVariables conversionVariables)
        {
            multiplicationExpression.Lhs.Visit(this, conversionParameters, conversionVariables);
            multiplicationExpression.Rhs.Visit(this, conversionParameters, conversionVariables);
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression" />.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Divide(
            DivisionExpression divisionExpression,
            ConversionParameters conversionParameters,
            ConversionVariables conversionVariables)
        {
            divisionExpression.Lhs.Visit(this, conversionParameters, conversionVariables);
            divisionExpression.Rhs.Visit(this, conversionParameters, new ConversionVariables(conversionVariables.Exponent * -1, true));
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression" />.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Magnitude(
            MagnitudeExpression magnitudeExpression,
            ConversionParameters conversionParameters,
            ConversionVariables conversionVariables)
        {
            magnitudeExpression.Lhs.Visit(
                this,
                conversionParameters,
                new ConversionVariables(conversionVariables.Exponent * magnitudeExpression.Rhs.Constant, conversionVariables.ExpressionIsPartOfDenominator));
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression" />.
        /// </summary>
        /// <param name="parenthesisExpression">The parenthesis expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            ConversionParameters conversionParameters,
            ConversionVariables conversionVariables)
        {
            parenthesisExpression.Expression.Visit(this, conversionParameters, conversionVariables);
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression" />.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Unit(UnitExpression unitExpression, ConversionParameters conversionParameters, ConversionVariables conversionVariables)
        {
            conversionParameters.FlatRepresentationBuilder.Add(unitExpression, conversionParameters.ReduceUsingBaseUnits, conversionVariables.Exponent);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression" />.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Variable(VariableExpression variableExpression, ConversionParameters conversionParameters, ConversionVariables conversionVariables)
        {
            conversionParameters.FlatRepresentationBuilder.Add(variableExpression, conversionVariables.Exponent);
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression" />.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="conversionParameters">The conversion parameters.</param>
        /// <param name="conversionVariables">The conversion variables.</param>
        public void Constant(ConstantExpression constantExpression, ConversionParameters conversionParameters, ConversionVariables conversionVariables)
        {
            conversionParameters.FlatRepresentationBuilder.Add(constantExpression, conversionVariables.Exponent);
        }
    }
}