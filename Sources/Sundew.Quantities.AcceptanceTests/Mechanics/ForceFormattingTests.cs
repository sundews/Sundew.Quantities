namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Mechanics;

    using Xunit;

    public class ForceFormattingTests
    {
        [Theory]
        [InlineData(UnitFormat.Default, "1 N")]
        [InlineData(UnitFormat.SurroundInBrackets, "1 [N]")]
        public void Force_ToString_When_UnitModeIsSpecified_Then_ResultShouldBeExpected(UnitFormat unitFormat, string expected)
        {
            var testee = new Force(1, x => x.Newtons);

            var result = testee.ToString(unitFormat);

            result.Should().Be(expected);
        } 
    }
}