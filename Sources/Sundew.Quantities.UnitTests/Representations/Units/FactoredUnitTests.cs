// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FactoredUnitTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Representations.Units
{
    using FluentAssertions;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class FactoredUnitTests
    {
        private const string ExpectedNotation = "anyDistance";

        private const double ExpectedFactor = 4;

        private readonly FactoredUnit testee = new FactoredUnit(ExpectedFactor, ExpectedNotation, UnitDefinitions.Meter);

        [Theory]
        [InlineData("kanyDistance")]
        public void GetPrefixedUnit_Then_ResultNotationShouldBeExpectedNotation(string expectedNotation)
        {
            var result = this.testee.GetPrefixedUnit(Prefixes.Kilo);

            result.Notation.Should().Be(expectedNotation);
        }

        [Theory]
        [InlineData(1000)]
        public void GetPrefixedUnit_Then_ResultPrefixFactorShouldBeExpectedPrefixFactor(double expectedPrefixFactor)
        {
            var result = this.testee.GetPrefixedUnit(Prefixes.Kilo);

            result.PrefixFactor.Should().Be(expectedPrefixFactor);
        }

        [Theory]
        [InlineData("m")]
        public void BaseUnitGetNotation_ThenResultShouldBeExpectedNotation(string expectedNotation)
        {
            var result = this.testee.BaseUnit.GetNotation();

            result.Should().Be(expectedNotation);
        }

        [Fact]
        public void GetNotationWithoutPrefix_ThenResultShouldBeExpectedNotation()
        {
            var result = this.testee.GetNotationWithoutPrefix();

            result.Should().Be(ExpectedNotation);
        }

        [Fact]
        public void Notation_Then_ResultShouldBeAnyNotation()
        {
            var result = this.testee.Notation;

            result.Should().Be(ExpectedNotation);
        }

        [Fact]
        public void PrefixFactor_Then_ResultShouldBe1()
        {
            var result = this.testee.PrefixFactor;

            result.Should().Be(1);
        }
    }
}