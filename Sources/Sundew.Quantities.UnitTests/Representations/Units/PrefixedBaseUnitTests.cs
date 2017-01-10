// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrefixedBaseUnitTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Units
{
    using FluentAssertions;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Expressions.Visitors;
    using Sundew.Quantities.Representations.Units;
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