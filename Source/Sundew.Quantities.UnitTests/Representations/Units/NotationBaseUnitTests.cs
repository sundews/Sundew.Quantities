// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotationBaseUnitTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Units;

using FluentAssertions;
using Sundew.Quantities.Representations.Units;
using Xunit;

public class NotationBaseUnitTests
{
    [Fact]
    public void FromBase_When_UnitIsGramAndBaseUnitIsKiloGram_ThenResultShouldBeExpected()
    {
        const double Expected = 1000;
        var testee = new NotationBaseUnit("g", new PrefixedBaseUnit(Prefixes.Kilo, "g"));

        var result = testee.FromBase(1);

        result.Should().Be(Expected);
    }

    [Fact]
    public void GetBaseNotation_Then_ResultShouldBeKg()
    {
        var testee = new NotationBaseUnit("g", new PrefixedBaseUnit(Prefixes.Kilo, "g"));

        var result = testee.GetBaseNotation();

        result.Should().Be("kg");
    }

    [Fact]
    public void ToBase_When_UnitIsGramAndBaseUnitIsKiloGram_ThenResultShouldBeExpected()
    {
        const double Expected = 0.001;
        var testee = new NotationBaseUnit("g", new PrefixedBaseUnit(Prefixes.Kilo, "g"));

        var result = testee.ToBase(1);

        result.Should().Be(Expected);
    }
}