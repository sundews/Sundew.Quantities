// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ElectricCurrentMultiplicationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Xunit;

    public class ElectricCurrentMultiplicationTests
    {
        [Theory]
        [InlineData(2, 3, 6, UnitFormat.Default, "C")]
        [InlineData(2, 3, 6, UnitFormat.SurroundInBrackets, "[C]")]
        public void ElectricCurrent_Multiplication_When_RhsIsTime_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected,
            UnitFormat unitFormat,
            string expectedUnit)
        {
            var testee = new ElectricCurrent(lhs, x => x.Amperes);
            var time = new Time(rhs, x => x.Seconds);

            var result = testee * time;

            result.Should().Be(expected, expectedUnit, unitFormat);
        }

        [Theory]
        [InlineData(5, 12, 60, "μW")]
        [InlineData(0, 11, 0, "μW")]
        public void ElectricCurrent_Multiplication_When_RhsIsIsPotential_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expectedValue,
            string expectedUnit)
        {
            var testee = new ElectricCurrent(lhs, x => x.Milli.Amperes);
            var potential = new Potential(rhs, x => x.Milli.Volts);

            var result = testee * potential;

            result.Should().Be(expectedValue, expectedUnit, UnitFormat.Default);
        }
    }
}