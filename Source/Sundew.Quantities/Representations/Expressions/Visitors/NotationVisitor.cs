// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotationVisitor.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors
{
    using System.Globalization;
    using System.Text;
    using Sundew.Base.Primitives.Visiting;
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Representations.Internals;

    /// <summary>
    /// Notation visitor for converting <see cref="Expression"/>s into its string notation.
    /// </summary>
    public class NotationVisitor : IExpressionVisitor<NotationParameters, NotationVariables, string>
    {
        private readonly NotationOptions notationOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotationVisitor"/> class.
        /// </summary>
        /// <param name="notationOptions">The notation options.</param>
        public NotationVisitor(NotationOptions notationOptions)
        {
            this.notationOptions = notationOptions ?? NotationOptions.Default;
        }

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        /// <returns>
        /// The resulting string notation.
        /// </returns>
        public string Visit(
            Expression expression,
            NotationParameters notationParameters = null,
            NotationVariables notationVariables = null)
        {
            notationParameters = notationParameters ?? new NotationParameters(CultureInfo.CurrentCulture, new StringBuilder());
            notationVariables = notationVariables ?? new NotationVariables(false, false);
            expression.Visit(this, notationParameters, notationVariables);
            return notationParameters.StringBuilder.ToString();
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression" />.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            NotationParameters notationParameters,
            NotationVariables notationVariables)
        {
            var requestPrecendence = notationVariables.RequestPrecedence;
            var stringBuilder = notationParameters.StringBuilder;
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            multiplicationExpression.Lhs.Visit(this, notationParameters, new NotationVariables(false, true));
            stringBuilder.Append(Constants.Multiply);
            multiplicationExpression.Rhs.Visit(this, notationParameters, new NotationVariables(true, true));
            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression" />.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Divide(
            DivisionExpression divisionExpression,
            NotationParameters notationParameters,
            NotationVariables notationVariables)
        {
            var requestPrecendence = notationVariables.RequestPrecedence;
            var stringBuilder = notationParameters.StringBuilder;
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            divisionExpression.Lhs.Visit(this, notationParameters, new NotationVariables(false, true));
            stringBuilder.Append(Constants.Divide);
            divisionExpression.Rhs.Visit(this, notationParameters, new NotationVariables(true, true));
            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression" />.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Magnitude(
            MagnitudeExpression magnitudeExpression,
            NotationParameters notationParameters,
            NotationVariables notationVariables)
        {
            var requestPrecendence = notationVariables.RequestPrecedence;
            var stringBuilder = notationParameters.StringBuilder;
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            magnitudeExpression.Lhs.Visit(this, notationParameters, new NotationVariables(true, true));
            var constant = magnitudeExpression.Rhs.Constant.ToString(notationParameters.FormatProvider);
            switch (this.notationOptions.MagnitudeFormat)
            {
                case MagnitudeFormat.UseAboveLetter:
                    if (magnitudeExpression.Lhs is MagnitudeExpression)
                    {
                        stringBuilder.Append(Constants.Power);
                    }

                    stringBuilder.Append(CharacterConverter.ToExponentNotation(constant));
                    break;
                default:
                    stringBuilder.Append(Constants.Power);
                    stringBuilder.Append(constant);
                    break;
            }

            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression" />.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            NotationParameters notationParameters,
            NotationVariables notationVariables)
        {
            var requestPrecendence = notationVariables.RequestPrecedence;
            var stringBuilder = notationParameters.StringBuilder;
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            stringBuilder.Append(Constants.LeftParenthesis);
            parenthesisExpression.Expression.Visit(this, notationParameters, new NotationVariables(false, true));
            stringBuilder.Append(Constants.RightParenthesis);
            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression" />.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Unit(
            UnitExpression unitExpression,
            NotationParameters notationParameters,
            NotationVariables notationVariables)
        {
            notationParameters.StringBuilder.Append(unitExpression.Unit.Notation);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression" />.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Variable(
            VariableExpression variableExpression,
            NotationParameters notationParameters,
            NotationVariables notationVariables)
        {
            notationParameters.StringBuilder.Append(variableExpression.VariableName);
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression" />.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void Constant(ConstantExpression constantExpression, NotationParameters notationParameters, NotationVariables notationVariables)
        {
            notationParameters.StringBuilder.Append(constantExpression.Constant.ToString(notationParameters.FormatProvider));
        }

        /// <summary>
        /// Visits the unknown.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="notationParameters">The notation parameters.</param>
        /// <param name="notationVariables">The notation variables.</param>
        public void VisitUnknown(Expression expression, NotationParameters notationParameters, NotationVariables notationVariables)
        {
            throw VisitException.Create(expression, notationParameters, notationVariables);
        }

        private void HandleLeftPrecedence(bool requestPrecendence, StringBuilder stringBuilder)
        {
            switch (this.notationOptions.OrderFormat)
            {
                case OperationOrderFormat.Parentheses:
                    stringBuilder.Append(Constants.LeftParenthesis);
                    return;
                case OperationOrderFormat.CurlyBrackets:
                    if (requestPrecendence)
                    {
                        stringBuilder.Append(Constants.LeftWeakParenthesis);
                    }

                    return;
            }
        }

        private void HandleRightPrecedence(bool requestPrecendence, StringBuilder stringBuilder)
        {
            switch (this.notationOptions.OrderFormat)
            {
                case OperationOrderFormat.Parentheses:
                    stringBuilder.Append(Constants.RightParenthesis);
                    return;
                case OperationOrderFormat.CurlyBrackets:
                    if (requestPrecendence)
                    {
                        stringBuilder.Append(Constants.RightWeakParenthesis);
                    }

                    return;
            }
        }
    }
}