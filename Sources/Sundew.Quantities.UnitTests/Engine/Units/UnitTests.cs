namespace Sundew.Quantities.UnitTests.Engine.Units
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class UnitTests
    {
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

        [Theory]
        [InlineData("km")]
        public void GetPrefixedUnit_Then_ResultNotationShouldBeExpectedNotation(string expectedNotation)
        {
            var testee = new Unit("m");

            var result = testee.GetPrefixedUnit(Prefixes.Kilo);

            result.Notation.Should().Be(expectedNotation);
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
        public void GetNotationWithoutPrefix_ThenResultShouldBeExpectedNotation()
        {
            const string ExpectedNotation = "m";
            var testee = new Unit(Prefixes.Kilo, ExpectedNotation);

            var result = testee.GetNotationWithoutPrefix();

            result.Should().Be(ExpectedNotation);
        }

        [Fact]
        public void BaseUnitGetNotation_ThenResultShouldBeExpectedNotation()
        {
            const string ExpectedNotation = "m";
            var testee = new Unit(Prefixes.Kilo, ExpectedNotation);

            var result = testee.BaseUnit.GetNotation();

            result.Should().Be(ExpectedNotation);
        }
    }
}