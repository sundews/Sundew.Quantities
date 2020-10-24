// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Units
{
    using FluentAssertions;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class UnitTests
    {
        [Fact]
        public void GetPrefixedUnit_Then_ResultNotationShouldBeExpectedNotation()
        {
            const string ExpectedNotation = "km";
            var testee = new Unit("m");

            var result = testee.GetPrefixedUnit(Prefixes.Kilo);

            result.Notation.Should().Be(ExpectedNotation);
        }

        [Theory]
        [InlineData(1000)]
        public void GetPrefixedUnit_Then_ResultPrefixFactorShouldBeExpectedPrefixFactor(double expectedPrefixFactor)
        {
            var testee = new Unit("m");

            var result = testee.GetPrefixedUnit(Prefixes.Kilo);

            result.PrefixFactor.Should().Be(expectedPrefixFactor);
        }

        [Fact]
        public void BaseUnitGetNotation_ThenResultShouldBeExpectedNotation()
        {
            const string ExpectedNotation = "m";
            var testee = new Unit(Prefixes.Kilo, ExpectedNotation);

            var result = testee.BaseUnit.GetNotation();

            result.Should().Be(ExpectedNotation);
        }

        [Fact]
        public void GetNotationWithoutPrefix_ThenResultShouldBeExpectedNotation()
        {
            const string ExpectedNotation = "m";
            var testee = new Unit(Prefixes.Kilo, ExpectedNotation);

            var result = testee.GetNotationWithoutPrefix();

            result.Should().Be(ExpectedNotation);
        }

        [Fact]
        public void Notation_Then_ResultShouldBeExpected()
        {
            const string ExpectedNotation = "g";
            var testee = new Unit(ExpectedNotation);

            var result = testee.Notation;

            result.Should().Be(ExpectedNotation);
        }

        [Fact]
        public void PrefixFactor_Then_ResultShouldBe1()
        {
            var testee = new Unit("m");

            var result = testee.PrefixFactor;

            result.Should().Be(1);
        }
    }
}