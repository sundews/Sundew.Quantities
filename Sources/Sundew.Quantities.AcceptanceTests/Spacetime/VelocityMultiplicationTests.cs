namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Spacetime;

    using Xunit;

    public class VelocityMultiplicationTests
    {
        [Theory]
        [InlineData(20, 1, 72000.0)]
        [InlineData(23.0, 0.0, 0.0)]
        [InlineData(0.0, 4.0, 0.0)]
        [InlineData(20, 1.5, 108000.0)]
        public void Velocity_Multiplication_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee = new Velocity(lhs, x => x.Meters / x.Seconds);
            var time = new Time(rhs, x => x.Hours);

            var result = testee * time;

            result.Should().Be(expected, "m");
        }  
    }
}