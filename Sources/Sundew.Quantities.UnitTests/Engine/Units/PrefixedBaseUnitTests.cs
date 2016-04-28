namespace Sundew.Quantities.UnitTests.Engine.Units
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class PrefixedBaseUnitTests
    {
        private readonly PrefixedBaseUnit testee = new PrefixedBaseUnit(Prefixes.Kilo, "g");

        [Fact]
        public void GetBaseNotation_Then_ResultShouldBeKg()
        {
            var result = this.testee.GetBaseNotation();

            result.Should().Be("kg");
        }

        [Fact]
        public void GetBaseExpression_ThenResultShouldBeResultGetBaseExpression()
        {
            var result = this.testee.GetBaseExpression();

            result.Should().Be(DefaultVisitors.BaseExpressionVisitor.Visit(result));
        }

        [Theory]
        [InlineData("mg")]
        public void GetPrefixedUnit_When_PrefixIsMilli_Then_ResultNotationShouldBeExpectedNotation(string expectedNotation)
        {
            var result = this.testee.GetPrefixedUnit(Prefixes.Milli);

            result.Notation.Should().Be(expectedNotation);
        }

        [Theory]
        [InlineData("g")]
        public void GetPrefixedUnit_When_PrefixIsNone_Then_ResultNotationShouldBeExpectedNotation(string expectedNotation)
        {
            var result = this.testee.GetPrefixedUnit(Prefix.None);

            result.Notation.Should().Be(expectedNotation);
        }
    }
}