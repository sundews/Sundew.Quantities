namespace Sundew.Quantities.AcceptanceTests.Periodics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class TimeTests
    {
        [Theory]
        [InlineData(3, 3000000000)]
        [InlineData(0, 0)]
        public void Time_ToUnit_Then_ResultShouldBeExpected(double value, double expected)
        {
            var time = new Time(value, selector => selector.Seconds);

            var result = time.ToUnit(selector => selector.Nano.Seconds);

            result.Should().BeApproximately(expected, "ns", TestHelper.DefaultAssertPrecision);
        }

        [Fact]
        public void Time_Division_ThenTimeIsRhs_Then_ResultShouldBeExpected()
        {
            const double Expected = 5000000;
            const double Value = 20000000;
            var time = new Time(4, units => units.Seconds);

            var result = Value / time;

            result.Should().Be(Expected, "Hz", UnitFormat.Default);
        }

        [Fact]
        public void Time_Division_ThenTimeInYearsIsRhs_Then_ResultShouldBeExpected()
        {
            const double Expected = 5000000;
            const double Value = 20000000;
            var time = new Time(4, units => units.Years);

            var result = Value / time;

            result.Should().Be(Expected, "1/y", UnitFormat.Default);
        }
    }
}