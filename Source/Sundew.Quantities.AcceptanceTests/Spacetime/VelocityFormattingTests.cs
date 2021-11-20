// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VelocityFormattingTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spacetime;

using FluentAssertions;
using Sundew.Quantities.Core;
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