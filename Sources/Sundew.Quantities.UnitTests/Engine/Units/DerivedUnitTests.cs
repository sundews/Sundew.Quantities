namespace Sundew.Quantities.UnitTests.Engine.Units
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class DerivedUnitTests
    {
        private static readonly Unit MeterUnit = new Unit("m");
        private static readonly Expression CentiMeterUnitExpression = Prefixes.Centi * MeterUnit;

        [Fact]
        public void CompositeUnitMultiplication_When_PrefixesAreDifferent_Then_NotationShouldBeLhsPrefixTimesRhsPrefix()
        {
            var testee = new DerivedUnit(null, MeterUnit * CentiMeterUnitExpression);

            testee.ToString().Should().Be("m*cm");
        }

        [Fact]
        public void CompositeUnitDivision_When_PrefixesAreDifferent_Then_NotationShouldBeRhsPrefixSquared()
        {
            var testee = new DerivedUnit(null, MeterUnit / CentiMeterUnitExpression);

            testee.ToString().Should().Be("m/cm");
        }

        [Theory]
        [InlineData("cm²", "cm²")]
        [InlineData(null, "cm*cm")]
        public void GetNotationWithoutPrefix_Then_ResultShouldBeExpected(string notation, string expected)
        {
            var testee = new DerivedUnit(notation, CentiMeterUnitExpression * CentiMeterUnitExpression);

            var result = testee.GetNotationWithoutPrefix();

            result.Should().Be(expected);
        }
    }
}