namespace Sundew.Quantities.AcceptanceTests.Periodics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Periodics;

    using Xunit;

    public class FrequencyTests
    {
        [Theory]
        [InlineData(3, 3000000000)]
        [InlineData(0, 0)]
        public void Frequency_ToUnit_Then_ResultShouldBeExpected(double value, double expected)
        {
            var testee = new Frequency(4, x => x.Mega.Hertz);

            var result = testee.ToUnit(x => x.Hertz);

            result.Should().Be(4000000, "Hz", UnitFormat.Default);
        }
    }
}