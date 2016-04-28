namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Mechanics;

    using Xunit;

    public class PressureAdditionTests
    {
        [Theory]
        [InlineData(5000, 2, 205000)]
        [InlineData(8000, 0, 8000)]
        public void Pressure_Addition_When_AddingPascalAndBar_ThenResultShouldBeExpected(double lhsValue, double rhsValue, double expected)
        {
            var lhs = new Pressure(lhsValue);
            var rhs = new Pressure(rhsValue, units => units.Bars);

            var result = lhs + rhs;

            result.Should().Be(expected, "Pa");
        }
    }
}