namespace Sundew.Quantities.Formatters.MathML.UnitTests
{
    using FluentAssertions;

    using Sundew.Quantities.Electromagnetism;
    using Sundew.Quantities.Spacetime;

    using Xunit;

    public class ExpressionToMathMLVisitorTests
    {
        private readonly ExpressionToMathMLVisitor testee;

        public ExpressionToMathMLVisitorTests()
        {
            this.testee = new ExpressionToMathMLVisitor();
        }

        [Fact]
        public void Visit_When_QuantityIsAcceleration_Then_ResultTextShouldBeExpectedResult()
        {
            const string ExpectedResult =
@"<mml:math xmlns:mml=""http://www.w3.org/1998/Math/MathML"">
  <mml:mfrac>
    <mml:mrow>
      <mml:mi mathvariant=""normal"" class=""MathML-Unit"">m</mml:mi>
    </mml:mrow>
    <mml:mrow>
      <mml:msup>
        <mml:mi mathvariant=""normal"" class=""MathML-Unit"">s</mml:mi>
        <mml:mn>2</mml:mn>
      </mml:msup>
    </mml:mrow>
  </mml:mfrac>
</mml:math>";

            var acceleration = 4.MetersPerSecondSquared();

            var result = this.testee.Visit(acceleration.Unit.GetExpression());

            result.ToString().Should().Be(ExpectedResult);
        }

        [Fact]
        public void Visit_When_QuantityIsVoltBaseUnit_Then_ResultTextShouldBeExpectedResult()
        {
            const string ExpectedResult =
@"<mml:math xmlns:mml=""http://www.w3.org/1998/Math/MathML"">
  <mml:mfrac>
    <mml:mrow>
      <mml:mi mathvariant=""normal"" class=""MathML-Unit"">kg</mml:mi>
      <mml:mo>*</mml:mo>
      <mml:msup>
        <mml:mi mathvariant=""normal"" class=""MathML-Unit"">m</mml:mi>
        <mml:mn>2</mml:mn>
      </mml:msup>
    </mml:mrow>
    <mml:mrow>
      <mml:mi mathvariant=""normal"" class=""MathML-Unit"">A</mml:mi>
      <mml:mo>*</mml:mo>
      <mml:msup>
        <mml:mi mathvariant=""normal"" class=""MathML-Unit"">s</mml:mi>
        <mml:mn>3</mml:mn>
      </mml:msup>
    </mml:mrow>
  </mml:mfrac>
</mml:math>";

            var acceleration = 4.Volts();

            var result = this.testee.Visit(acceleration.Unit.BaseUnit.GetExpression(), MultiplicationSign.Star);

            result.ToString().Should().Be(ExpectedResult);
        }
    }
}