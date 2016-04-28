namespace Sundew.Quantities.AcceptanceTests
{
    using System.Globalization;

    using FluentAssertions;

    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;

    using Xunit;

    public class UnitSystemTests
    {
        [Theory]
        [InlineData("C", "A*s")]
        [InlineData("A", "A")]
        public void GetUnit_Then_ResultBaseUnitNotationShouldBeExpected(string unit, string expected)
        {
            var testee = new UnitSystem();
            testee.InitializeUnitSystemWithDefaults();

            var result = testee.GetUnit(unit, ParseSettings.DefaultInvariantCulture).Value;

            result.BaseUnit.GetNotation().Should().Be(expected);
        }
    }
}