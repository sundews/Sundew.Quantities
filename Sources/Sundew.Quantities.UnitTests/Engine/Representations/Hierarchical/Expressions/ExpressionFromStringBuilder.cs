// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExpressionFromStringBuilder.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Units;

namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Expressions
{
    using System.Globalization;

    internal class ExpressionFromStringBuilder
    {
        public static MultiplicationExpression CreateMultiplicationExpression(string[] expressions)
        {
            return CreateExpression(expressions) as MultiplicationExpression;
        }

        public static DivisionExpression CreateDivisionExpression(string[] expressions)
        {
            return CreateExpression(expressions) as DivisionExpression;
        }

        public static Expression CreateExpression(params string[] expressions)
        {
            int index = 0;
            return CreateExpression(expressions, ref index);
        }

        private static Expression CreateExpression(string[] expressions, ref int index)
        {
            var operation = expressions[index++];
            switch (operation)
            {
                case "*":
                    return new MultiplicationExpression(
                        CreateExpression(expressions, ref index),
                        CreateExpression(expressions, ref index));
                case "/":
                    return new DivisionExpression(
                        CreateExpression(expressions, ref index),
                        CreateExpression(expressions, ref index));
                default:
                    double constant;
                    if (double.TryParse(operation, out constant))
                    {
                        return new ConstantExpression(constant);
                    }

                    return new UnitExpression(new Unit(operation.ToString(CultureInfo.CurrentCulture)));
            }
        }
    }
}