namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Internals;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class VolumeDivisionTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Volume_Division_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Volume(lhs, x => x.Meters * x.Meters * x.Meters);
            var testee2 = new Volume(rhs, x => x.Meters * x.Meters * x.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        [InlineData(27, 25, 1.08)]
        public void Volume_Division_When_DividingWithArea_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Volume(lhs, x => x.Meters * x.Meters * x.Meters);
            var testee2 = new Area(rhs, x => x.Meters * x.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        [InlineData(27, 25, 1.08)]
        public void Volume_Division_When_DividingWithLength_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Volume(lhs, x => x.Cubic.Meters);
            var testee2 = new Distance(rhs, x => x.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected, "m" + Constants.Exponent2);
        }

        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Volume_Division_When_DividingWithAnyNumber_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee = new Volume(lhs, x => x.Meters * x.Meters * x.Meters);

            var result = testee / rhs;

            result.Should().Be(expected, "m" + Constants.Exponent3);
        } 
    }
}