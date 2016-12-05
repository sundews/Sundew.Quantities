// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="VelocityFormattingTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;
    using Xunit;

    public class VelocityFormattingTests
    {
        [Theory]
        [InlineData(UnitFormat.Default, "1 km/h")]
        [InlineData(UnitFormat.SurroundInBrackets, "1 [km/h]")]
        public void Velocity_ToString_When_UnitModeIsSpecified_Then_ResultShouldBeExpected(
            UnitFormat unitFormat,
            string expected)
        {
            var testee = new Velocity(1, x => x.Kilo.Meters / x.Hours);

            var result = testee.ToString(unitFormat);

            result.Should().Be(expected);
        }
    }
}