// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityToMathMLVisitorTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Formatters.MathML.UnitTests
{
    using FluentAssertions;
    using Xunit;

    public class QuantityToMathMLVisitorTests
    {
        [Fact]
        public void GetMathML_WhenUsingDefaultUnitFormat_Then_ResultToStringShouldBeExpectedResult()
        {
            const string ExpectedResult = @"<mml:math xmlns:mml=""http://www.w3.org/1998/Math/MathML"">
  <mml:mrow>
    <mml:mn>4</mml:mn>
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
  </mml:mrow>
</mml:math>";
            var testee = new QuantityToMathMLConverter();

            var result = testee.GetMathML(4.MetersPerSecondSquared()).ToString();

            result.Should().Be(ExpectedResult);
        }

        [Fact]
        public void GetMathML_WhenUsingSquareBracketsUnitFormat_Then_ResultToStringShouldBeExpectedResult()
        {
            const string ExpectedResult = @"<mml:math xmlns:mml=""http://www.w3.org/1998/Math/MathML"">
  <mml:mrow>
    <mml:mn>4</mml:mn>
    <mml:mfenced open=""["" close=""]"">
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
    </mml:mfenced>
  </mml:mrow>
</mml:math>";
            var testee = new QuantityToMathMLConverter();

            var result = testee.GetMathML(4.MetersPerSecondSquared(), UnitFormat.SurroundInBrackets).ToString();

            result.Should().Be(ExpectedResult);
        }
    }
}