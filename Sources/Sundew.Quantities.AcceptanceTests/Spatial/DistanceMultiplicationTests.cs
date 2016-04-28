namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Spatial;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class DistanceMultiplicationTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 30.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -2000.0)]
        public void Distance_Multiplication_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Distance(rhs, x => x.Meters);

            var result = testee1 * testee2;

            result.Should().Be(expected, "m²");
        }

        [Theory]
        [InlineData(3.0, 10.0, 30.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -2000.0)]
        public void Distance_Multiplication_When_MultiplyingWithAnyNumber_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);

            var result = testee1 * rhs;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(3.0, 30.0, 0.9)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -20.0)]
        public void Distance_Multiplication_When_PrefixesAreDifferent_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Distance(rhs, x => x.Centi.Meters);

            var result = testee1 * testee2;

            result.Should().BeApproximately(expected, "m²", TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(2.0, 20.0, 4)]
        [InlineData(2.0, 0.0, 0)]
        public void Distance_Multiplication_When_UnitsAndPrefixesAreDifferent_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Deci.Meters);
            var testee2 = new Distance(rhs, x => x.Centi.Meters);

            var result = testee1 * testee2;

            result.Should().BeApproximately(expected, "dm²", TestHelper.DefaultAssertPrecision);
        }
    }
}