// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PowerMultiplicationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Xunit;

    public class PowerMultiplicationTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, 4, 20)]
        public void Power_Multiplication_When_RhsIsSeconds_ThenResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var watt = new Power(lhs, units => units.Watts);
            var time = new Time(rhs, x => x.Seconds);

            var result = watt * time;

            result.Should().Be(expected, "J", UnitFormat.Default);
        }
    }
}