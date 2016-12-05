// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PrefixedBaseUnitTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Expressions.Visitors;
using Sundew.Quantities.Representations.Units;

namespace Sundew.Quantities.UnitTests.Engine.Units
{
    using FluentAssertions;
    using Xunit;

    public class PrefixedBaseUnitTests
    {
        private readonly PrefixedBaseUnit testee = new PrefixedBaseUnit(Prefixes.Kilo, "g");

        [Theory]
        [InlineData("mg")]
        public void GetPrefixedUnit_When_PrefixIsMilli_Then_ResultNotationShouldBeExpectedNotation(
            string expectedNotation)
        {
            var result = this.testee.GetPrefixedUnit(Prefixes.Milli);

            result.Notation.Should().Be(expectedNotation);
        }

        [Theory]
        [InlineData("g")]
        public void GetPrefixedUnit_When_PrefixIsNone_Then_ResultNotationShouldBeExpectedNotation(
            string expectedNotation)
        {
            var result = this.testee.GetPrefixedUnit(Prefix.None);

            result.Notation.Should().Be(expectedNotation);
        }

        [Fact]
        public void GetBaseExpression_ThenResultShouldBeResultGetBaseExpression()
        {
            var result = this.testee.GetBaseExpression();

            result.Should().Be(DefaultVisitors.BaseExpressionVisitor.Visit(result));
        }

        [Fact]
        public void GetBaseNotation_Then_ResultShouldBeKg()
        {
            var result = this.testee.GetBaseNotation();

            result.Should().Be("kg");
        }
    }
}