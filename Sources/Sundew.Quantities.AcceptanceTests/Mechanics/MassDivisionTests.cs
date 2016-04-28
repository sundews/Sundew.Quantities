namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class MassDivisionTests
    {
        [Fact]
        public void Mass_Multiplication_When_RhsIsMeterSeconds_Then_ResultShouldBeExpected()
        {
            const double Expected = 92;
            var mass = 46.KiloGrams();
            var velocity = 2.Meters() / 1D.Seconds();

            var result = mass * velocity;

            result.Should().Be(Expected, "kg*m/s");
        }

        [Fact]
        public void Mass_Division_When_RhsIsMeterSecondsSquared_Then_ResultShouldBeExpected()
        {
            const double Expected = 23;
            var mass = 46.KiloGrams();
            var meterSecondsSquared = 2.Meters() * 1D.Seconds().Squared();

            var result = mass / meterSecondsSquared;

            result.Should().Be(Expected, "Pa");
        }
    }
}