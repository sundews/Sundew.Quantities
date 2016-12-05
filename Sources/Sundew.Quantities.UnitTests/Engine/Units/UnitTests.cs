// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations.Units;

namespace Sundew.Quantities.UnitTests.Engine.Units
{
    using FluentAssertions;
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