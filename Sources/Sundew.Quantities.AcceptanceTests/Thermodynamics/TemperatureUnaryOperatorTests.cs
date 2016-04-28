namespace Sundew.Quantities.AcceptanceTests.Thermodynamics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Thermodynamics;

    using Xunit;

    public class TemperatureUnaryOperatorTests
    {
        [Fact]
        public void Temperature_UnaryMinus_Then_ResultShouldBeNegated()
        {
            var testee = 43.Celsius();

            var result = -testee;

            result.Should().Be(-43, "°C");
        }

        [Fact]
        public void Temperature_Increment_Then_ResultShouldBePlusOne()
        {
            var testee = 43.Celsius();

            var result = ++testee;

            result.Should().Be(44, "°C");
        }

        [Fact]
        public void Temperature_Decrement_Then_ResultShouldBeMinusOne()
        {
            var testee = -43.Celsius();

            var result = ++testee;

            result.Should().Be(-42, "°C");
        }
    }
}