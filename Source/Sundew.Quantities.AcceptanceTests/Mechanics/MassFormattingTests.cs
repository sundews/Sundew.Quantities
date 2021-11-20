// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassFormattingTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Mechanics;

using FluentAssertions;
using Sundew.Quantities.Core;
using Xunit;

public class MassFormattingTests
{
    [Theory]
    [InlineData(UnitFormat.Default, "1 kg")]
    [InlineData(UnitFormat.SurroundInBrackets, "1 [kg]")]
    public void Mass_ToString_When_UnitIsKiloGram_Then_ResultShouldBeExpected(
        UnitFormat unitFormat,
        string expected)
    {
        var testee = new Mass(1, x => x.KiloGrams);

        var result = testee.ToString(unitFormat);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(UnitFormat.Default, 1, " g")]
    [InlineData(UnitFormat.SurroundInBrackets, 1, " [g]")]
    public void Mass_ToString_When_IsGram_Then_ResultShouldBeExpected(
        UnitFormat unitFormat,
        double expectedValue,
        string expectedUnit)
    {
        var expected = expectedValue + expectedUnit;
        var testee = new Mass(1, x => x.Grams);

        var result = testee.ToString(unitFormat);

        result.Should().Be(expected);
    }
}