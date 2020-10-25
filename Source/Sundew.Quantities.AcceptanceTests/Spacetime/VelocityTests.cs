// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VelocityTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class VelocityTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 32.18688)]
        public void Velocity_ToUnit_When_UnitsAreDifferent_Then_ResultShouldBeAsExpected(
            double velocity,
            double expected)
        {
            var testee = new Velocity(velocity, x => x.Miles / x.Hours);

            var result = testee.ToUnit(x => x.Kilo.Meters / x.Hours);

            result.Should().BeApproximately(expected, "km/h", TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(10, 2.7777777777777777777777777777778)]
        public void Velocity_ToUnit_When_ConvertingFromKiloMeterPerHourToMeterPerSecond_Then_ResultShouldBeAsExpected(
            double velocity,
            double expected)
        {
            var testee = new Velocity(velocity, x => x.Kilo.Meters / x.Hours);

            var result = testee.ToUnit(x => x.Meters / x.Seconds);

            result.Should().BeApproximately(expected, "m/s", TestHelper.DefaultAssertPrecision);
        }
    }
}