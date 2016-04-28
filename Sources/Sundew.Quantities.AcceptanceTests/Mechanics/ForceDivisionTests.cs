namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class ForceDivisionTests
    {
        [Fact]
        public void Force_Division_When_RhsIsArea_Then_ResultShouldBeExpected()
        {
            const double Expected = 8.6;
            var force = 43.Newtons();
            var area = 5.SquareMeters();

            var result = force / area;

            result.Should().Be(Expected, "Pa");
        }
    }
}