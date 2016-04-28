namespace Sundew.Quantities.AcceptanceTests.Thermodynamics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Thermodynamics;

    using Xunit;

    public class TemperatureAdditionTests
    {
        [Fact]
        public void Temperature_Addition_Then_ResultShouldBeSummed()
        {
            var lhs = 43.Celsius();
            var rhs = 32.Celsius();

            var result = lhs + rhs;

            result.Should().Be(75, "°C");
        }
    }
}