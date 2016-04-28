namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Spacetime;

    using Xunit;

    public class VelocityFormattingTests
    {
        [Theory]
        [InlineData(UnitFormat.Default, "1 km/h")]
        [InlineData(UnitFormat.SurroundInBrackets, "1 [km/h]")]
        public void Velocity_ToString_When_UnitModeIsSpecified_Then_ResultShouldBeExpected(UnitFormat unitFormat, string expected)
        {
            var testee = new Velocity(1, x => x.Kilo.Meters / x.Hours);

            var result = testee.ToString(unitFormat);

            result.Should().Be(expected);
        }
    }
}