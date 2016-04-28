namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Internals;
    using Sundew.Quantities.Spatial;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class AreaTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 7.72204317084892)]
        public void Area_ToUnit_When_UnitsAreDifferent_Then_ResultShouldBeAsExpected(double area, double expected)
        {
            var testee = new Area(area, x => x.Square.Kilo.Meters);

            var result = testee.ToUnit(x => x.Square.Miles);

            result.Should().BeApproximately(expected, "mi" + Constants.Exponent2, TestHelper.DefaultAssertPrecision);
        } 
        
        [Theory]
        [InlineData(20.0, 0.2)]
        [InlineData(0, 0)]
        public void Area_ToUnit_When_PrefixesAreDifferent_Then_ResultShouldBeExpected(double area, double expected)
        {
            var testee = new Area(area, x => x.Square.Centi.Meters);

            var result = testee.ToUnit(x => x.Square.Deci.Meters);

            result.Should().BeApproximately(expected, "dm" + Constants.Exponent2, TestHelper.DefaultAssertPrecision);
        }

        [Fact]
        public void Area_Ctor_ThenPrefixShouldBe()
        {
            var testee = new Area(4, units => units.Square.Kilo.Meters);

            var result = testee.Unit.PrefixFactor;

            result.Should().Be(1000000);
        }
    }
}