// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PressureAdditionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Mechanics;

using FluentAssertions;

using Sundew.Quantities.AcceptanceTests.Testing;

using Xunit;

public class PressureAdditionTests
{
    [Theory]
    [InlineData(5000, 2, 205000)]
    [InlineData(8000, 0, 8000)]
    public void Pressure_Addition_When_AddingPascalAndBar_ThenResultShouldBeExpected(
        double lhsValue,
        double rhsValue,
        double expected)
    {
        var lhs = new Pressure(lhsValue);
        var rhs = new Pressure(rhsValue, units => units.Bars);

        var result = lhs + rhs;

        result.Should().Be(expected, "Pa");
    }
}