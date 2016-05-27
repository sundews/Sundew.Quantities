// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="VolumeTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class VolumeTests
    {
        [Fact]
        public void Volume_DoubleToVolume_Then_ResultShouldBeExpected()
        {
            const double Expected = 43;
            var result = Expected.ToVolume(units => units.Milli.Liters);

            result.Should().Be(Expected, "mL");
        }

        [Theory]
        [InlineData(32, 0.032)]
        [InlineData(0, 0)]
        public void Volume_ToUnit_When_ConvertingLitersToCubicMeters_Then_ResultShouldBeExpected(
            double value,
            double expected)
        {
            var testee = value.ToVolume(units => units.Liters);

            var result = testee.ToUnit(units => units.Cubic.Meters);

            result.Should().Be(expected, "m³");
        }

        [Theory]
        [InlineData(54, 54000)]
        [InlineData(0, 0)]
        public void Volume_ToUnit_When_ConvertingCubicMetersToLiters_Then_ResultShouldBeExpected(
            double value,
            double expected)
        {
            var testee = value.ToVolume(units => units.Cubic.Meters);

            var result = testee.ToDouble(units => units.Liters);

            result.Should().Be(expected);
        }
    }
}