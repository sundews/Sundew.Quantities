namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.Mechanics;

    using Xunit;

    public class MassComparisonTests
    {
        [Theory]
        [InlineData(4, 4000, 0)]
        [InlineData(5, 3000, 1)]
        [InlineData(2, 3000, -1)]
        public void Mass_CompareTo_When_ComparingKiloGramsAndGrams_Then_ResultShouldBeExpected(double lhsValue, double rhsValue, int expected)
        {
            var lhs = lhsValue.KiloGrams();
            var rhs = rhsValue.Grams();

            var result = lhs.CompareTo(rhs);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(4000000, 5000, true)]
        [InlineData(4000000, 3000, false)]
        [InlineData(4000000, 4000, false)]
        public void Mass_LessThan_When_ComparingGramsAndTonnes_Then_ResultShouldBeExpected(double lhsValue, double rhsValue, bool expected)
        {
            var lhs = lhsValue.Grams();
            var rhs = rhsValue.KiloGrams().ToUnit(x => x.Tonnes);

            var result = lhs < rhs;

            result.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(4000000, 5000, false)]
        [InlineData(4000000, 3000, true)]
        [InlineData(4000000, 4000, false)]
        public void Mass_GreaterThan_When_ComparingGramsAndTonnes_Then_ResultShouldBeExpected(double lhsValue, double rhsValue, bool expected)
        {
            var lhs = lhsValue.Grams();
            var rhs = rhsValue.KiloGrams().ToUnit(x => x.Tonnes);

            var result = lhs > rhs;

            result.Should().Be(expected);
        }
    }
}