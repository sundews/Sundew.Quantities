// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DistanceTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.UnitTests;
    using Xunit;

    public class DistanceTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(55080508, 34.225440924998)]
        [InlineData(15508, 0.00963622444921658)]
        public void Distance_ToUnit_When_ConvertingFromMilliMeterToMile_Then_ResultShouldBeAsExpected(
            double length,
            double expected)
        {
            var testee = new Distance(length, x => x.Milli.Meters);

            IQuantity result = testee.ToUnit(x => x.Miles);

            result.Value.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }
    }
}