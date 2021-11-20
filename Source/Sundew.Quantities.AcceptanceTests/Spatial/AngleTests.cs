// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AngleTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial;

using System;

using FluentAssertions;

using Sundew.Quantities.AcceptanceTests.Testing;
using Sundew.Quantities.UnitTests;

using Xunit;

public class AngleTests
{
    [Theory]
    [InlineData(2, 114.59155902616465)]
    public void Angle_ToUnit_WhenConvertingFromRadiansToDegrees_ThenResultShouldBeExpected(
        double radians,
        double expected)
    {
        var angle = radians.Radians();

        var result = angle.ToUnit(units => units.Degrees);

        result.Should().BeApproximately(expected, "°", TestHelper.DefaultAssertPrecision);
    }

    [Theory]
    [InlineData(180, Math.PI)]
    public void Angle_ToUnit_WhenConvertingFromDegreesToRadians_ThenResultShouldBeExpected(
        double degrees,
        double expected)
    {
        var angle = degrees.ToAngle(units => units.Degrees);

        var result = angle.ToUnit(units => units.Radians);

        result.Should().BeApproximately(expected, "rad", TestHelper.DefaultAssertPrecision);
    }
}