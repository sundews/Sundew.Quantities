namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Spacetime;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class AccelerationTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 8.9408)]
        public void Acceleration_ToUnit_When_UnitsAreDifferent_Then_ResultShouldBeAsExpected(double acceleration, double expected)
        {
            var testee = new Acceleration(acceleration, selector => selector.Miles / selector.Hours / selector.Seconds);

            var result = testee.ToUnit(selector => selector.Meters / selector.Seconds / selector.Seconds);

            result.Should().BeApproximately(expected, "m/s²", TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 44.738725841088)]
        public void Acceleration_ToUnit_When_ConvertingFromMeterPerSecondPerSecondToMilePerHourSecond_Then_ResultShouldBeAsExpected(double acceleration, double expected)
        {
            var testee = new Acceleration(acceleration, selector => selector.Meters / selector.Seconds / selector.Seconds);

            var result = testee.ToUnit(selector => selector.Miles / selector.P(selector.Hours * selector.Seconds));

            result.Should().BeApproximately(expected, "mi/(h*s)", TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 44.738725841088)]
        public void Acceleration_ToUnit_When_ConvertingFromMeterPerSecondPerSecondToMilePerHourPerSecond_Then_ResultShouldBeAsExpected(double acceleration, double expected)
        {
            var testee = new Acceleration(acceleration, selector => selector.Meters / selector.Seconds / selector.Seconds);

            var result = testee.ToUnit(selector => selector.Miles / selector.Hours / selector.Seconds);

            result.Should().BeApproximately(expected, "mi/h/s", TestHelper.DefaultAssertPrecision);
        }
    }
}