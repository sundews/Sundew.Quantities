namespace Sundew.Quantities.UnitTests.Engine.Representations.Conversion
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.UnitTests.Engine.Representations.Flat;

    using Xunit;

    public class FlatRepresentationConsumerTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void GetResultingExpression_When_ExponentIsLargerThanOne_Then_ResultShouldContainMagnitudeExpression(double exponent)
        {
            var flatRepresentation = FlatUnit.CreateFlatRepresentation(new FlatUnit("s", exponent: exponent));
            var testee = flatRepresentation.GetConsumer();

            var result = testee.GetResultingExpression(new UnitExpression(new Unit("s")), false);

            var magnitudeAssertion = result.Should().BeOfType<MagnitudeExpression>();
            magnitudeAssertion.Which.Rhs.Constant.Should().Be(exponent);
            magnitudeAssertion.Which.Lhs.ToString().Should().Be("s");
        }

        [Fact]
        public void GetResultingExpression_When_UnitIsRequestedTwice_Then_ResultShouldBeNull()
        {
            var flatRepresentation = FlatUnit.CreateFlatRepresentation(new FlatUnit("s"));
            var testee = flatRepresentation.GetConsumer();
            testee.GetResultingExpression(new UnitExpression(new Unit("s")), false);

            var result = testee.GetResultingExpression(new UnitExpression(new Unit("s")), false);

            result.Should().BeNull();
        }

        [Fact]
        public void GetResultingExpression_When_UnitIsNotFound_Then_ResultShouldBeNull()
        {
            var flatRepresentation = FlatUnit.CreateFlatRepresentation(new FlatUnit("s"));
            var testee = flatRepresentation.GetConsumer();

            var result = testee.GetResultingExpression(new UnitExpression(new Unit("m")), false);

            result.Should().BeNull();
        }

        [Fact]
        public void GetResultingExpression_When_UnitReducedByBaseUnitAndBaseUnitIsAddedFirst_Then_ResultShouldBeBaseUnitExpression()
        {
            var flatRepresentation = FlatUnit.CreateFlatRepresentation(new FlatUnit("s"));
            var testee = flatRepresentation.GetConsumer();

            var result = testee.GetResultingExpression(new UnitExpression(new FactoredUnit(60, "min", new UnitExpression(new Unit("s")))), true);

            result.Should().BeOfType<UnitExpression>().Which.Unit.Notation.Should().Be("s");
        }

        [Fact]
        public void GetResultingExpression_When_UnitReducedByBaseUnitAndDerivedUnitIsAddedFirst_Then_ResultShouldBeBaseUnitExpression()
        {
            var flatRepresentation = FlatUnit.CreateFlatRepresentation(new FlatUnit("min", "s"));
            var testee = flatRepresentation.GetConsumer();

            var result = testee.GetResultingExpression(new UnitExpression(new Unit("s")), true);

            result.Should().BeOfType<UnitExpression>().Which.Unit.Notation.Should().Be("min");
        }

        [Fact]
        public void GetResultingExpression_When_BaseUnitIsAddedFirst_Then_ResultShouldBeNull()
        {
            var flatRepresentation = FlatUnit.CreateFlatRepresentation(new FlatUnit("s"));
            var testee = flatRepresentation.GetConsumer();

            var result = testee.GetResultingExpression(new UnitExpression(new FactoredUnit(60, "min", new UnitExpression(new Unit("s")))), false);

            result.Should().BeNull();
        }
    }
}