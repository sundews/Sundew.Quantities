// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MassFormattingTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;
    using Xunit;

    public class MassFormattingTests
    {
        [Theory]
        [InlineData(UnitFormat.Default, "1 kg")]
        [InlineData(UnitFormat.SurroundInBrackets, "1 [kg]")]
        public void Mass_ToString_When_UnitIsKiloGram_Then_ResultShouldBeExpected(
            UnitFormat unitFormat,
            string expected)
        {
            var testee = new Mass(1, x => x.KiloGrams);

            var result = testee.ToString(unitFormat);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(UnitFormat.Default, 1, " g")]
        [InlineData(UnitFormat.SurroundInBrackets, 1, " [g]")]
        public void Mass_ToString_When_IsGram_Then_ResultShouldBeExpected(
            UnitFormat unitFormat,
            double expectedValue,
            string expectedUnit)
        {
            var expected = expectedValue + expectedUnit;
            var testee = new Mass(1, x => x.Grams);

            var result = testee.ToString(unitFormat);

            result.Should().Be(expected);
        }
    }
}