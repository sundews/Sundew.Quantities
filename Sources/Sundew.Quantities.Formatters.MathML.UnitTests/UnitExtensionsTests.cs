// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitExtensionsTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Formatters.MathML.UnitTests
{
    using FluentAssertions;

    using Sundew.Quantities.Mechanics;

    using Xunit;

    public class UnitExtensionsTests
    {
        [Theory]
        [InlineData(MultiplicationSign.Invisible)]
        [InlineData(MultiplicationSign.Dot)]
        [InlineData(MultiplicationSign.Cross)]
        [InlineData(MultiplicationSign.Star)]
        public void ToMathMLString_When_UsingPowerBaseUnit_Then_ResultShouldBedExpectedResult(
            MultiplicationSign multiplicationSign)
        {
            string expectedResult =
                $@"<mml:math xmlns:mml=""http://www.w3.org/1998/Math/MathML"">
  <mml:mfrac>
    <mml:mrow>
      <mml:mi mathvariant=""normal"" class=""MathML-Unit"">kg</mml:mi>
      <mml:mo>{MathML
                    .GetMultiplicationSign(multiplicationSign)}</mml:mo>
      <mml:msup>
        <mml:mi mathvariant=""normal"" class=""MathML-Unit"">m</mml:mi>
        <mml:mn>2</mml:mn>
      </mml:msup>
    </mml:mrow>
    <mml:mrow>
      <mml:msup>
        <mml:mi mathvariant=""normal"" class=""MathML-Unit"">s</mml:mi>
        <mml:mn>3</mml:mn>
      </mml:msup>
    </mml:mrow>
  </mml:mfrac>
</mml:math>";
            var power = 54.Watts();

            var result = power.Unit.BaseUnit.ToMathMLString(multiplicationSign);

            result.Should().Be(expectedResult);
        }
    }
}