namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class VolumeTests
    {
        [Fact]
        public void Volume_DoubleToVolume_Then_ResultShouldBeExpected()
        {
            const double Expected = 43;
            var result = Expected.ToVolume(units => units.Milli.Liters);

            result.Should().Be(Expected, "mL");
        }

        [Fact]
        public void Volume_ToUnit_When_ConvertingLitersToCubicMeters_Then_ResultShouldBeExpected()
        {
            const double Expected = 0.032;
            var volume = 32.ToVolume(units => units.Liters);

            var result = volume.ToUnit(units => units.Cubic.Meters);

            result.Should().Be(Expected, "m³");
        }
    }
}