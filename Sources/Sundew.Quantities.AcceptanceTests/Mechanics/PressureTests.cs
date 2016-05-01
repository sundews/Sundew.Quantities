// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PressureTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class PressureTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(4, 58.015095202800005)]
        public void Pressure_ToUnit_When_ConvertingBarToPsi_Then_ResultShouldBeExpected(double value, double expected)
        {
            var testee = new Pressure(value, units => units.Bars);

            var result = testee.ToUnit(units => units.Psi);

            result.Should().BeApproximately(expected, "psi", TestHelper.DefaultAssertPrecision);
        }
    }
}