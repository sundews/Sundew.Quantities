// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotationVisitor.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors
{
    using System;
    using System.Globalization;
    using System.Text;
    using Sundew.Quantities.Representations.Internals;

    /// <summary>
    /// Notation visitor for converting <see cref="Expression"/>s into its string notation.
    /// </summary>
    public class NotationVisitor : IExpressionVisitor<IFormatProvider, bool, bool, StringBuilder, string>
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
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        /// <returns>
        /// The resulting string notation.
        /// </returns>
        public string Visit(
            Expression expression,
            IFormatProvider formatProvider = null,
            bool requestPrecendence = false,
            bool expressionIsChild = false,
            StringBuilder stringBuilder = null)
        {
            stringBuilder = stringBuilder ?? new StringBuilder();
            formatProvider = formatProvider ?? CultureInfo.CurrentCulture;
            expression.Visit(this, formatProvider, requestPrecendence, false, stringBuilder);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Visits a <see cref="MultiplicationExpression" />.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            multiplicationExpression.Lhs.Visit(this, formatProvider, false, true, stringBuilder);
            stringBuilder.Append(Constants.Multiply);
            multiplicationExpression.Rhs.Visit(this, formatProvider, true, true, stringBuilder);
            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="DivisionExpression" />.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Divide(
            DivisionExpression divisionExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            divisionExpression.Lhs.Visit(this, formatProvider, false, true, stringBuilder);
            stringBuilder.Append(Constants.Divide);
            divisionExpression.Rhs.Visit(this, formatProvider, true, true, stringBuilder);
            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression" />.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Magnitude(
            MagnitudeExpression magnitudeExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            magnitudeExpression.Lhs.Visit(this, formatProvider, true, true, stringBuilder);
            var constant = magnitudeExpression.Rhs.Constant.ToString(formatProvider);
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
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            this.HandleLeftPrecedence(requestPrecendence, stringBuilder);
            stringBuilder.Append(Constants.LeftParenthesis);
            parenthesisExpression.Expression.Visit(this, formatProvider, false, true, stringBuilder);
            stringBuilder.Append(Constants.RightParenthesis);
            this.HandleRightPrecedence(requestPrecendence, stringBuilder);
        }

        /// <summary>
        /// Visits a <see cref="UnitExpression" />.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Unit(
            UnitExpression unitExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            stringBuilder.Append(unitExpression.Unit.Notation);
        }

        /// <summary>
        /// Visits a <see cref="VariableExpression" />.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Variable(
            VariableExpression variableExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            stringBuilder.Append(variableExpression.VariableName);
        }

        /// <summary>
        /// Visits a <see cref="ConstantExpression" />.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="requestPrecendence">If set to <c>true</c> precedence is requested.</param>
        /// <param name="expressionIsChild">If set to <c>true</c> the expression is a child expression.</param>
        /// <param name="stringBuilder">The string builder.</param>
        public void Constant(
            ConstantExpression constantExpression,
            IFormatProvider formatProvider,
            bool requestPrecendence,
            bool expressionIsChild,
            StringBuilder stringBuilder)
        {
            stringBuilder.Append(constantExpression.Constant.ToString(formatProvider));
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