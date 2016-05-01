// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MultiplicationExpressionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Expressions
{
    using FluentAssertions;

    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class MultiplicationExpressionTests
    {
        [Theory]
        [InlineData(84, 1087340D)]
        [InlineData(0, 0D)]
        [InlineData(-102, 715339.99999999988D)]
        public void Visit_When_ConvertingFromFahrenheitSeconds_Then_ResultShouldBeExpected(
            double value,
            double expected)
        {
            var testee = new MultiplicationExpression(
                UnitDefinitions.Fahrenheit.GetExpression(),
                UnitDefinitions.Hour.GetExpression());
            var result = new Reference<double>();

            testee.Visit(new ValueToBaseVisitor(), value, result);

            result.Value.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }
    }
}