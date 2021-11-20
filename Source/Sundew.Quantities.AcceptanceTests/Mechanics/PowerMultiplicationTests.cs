// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerMultiplicationTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Mechanics;

using FluentAssertions;
using Sundew.Quantities.AcceptanceTests.Testing;
using Sundew.Quantities.Core;
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