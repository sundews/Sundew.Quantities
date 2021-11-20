﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResistanceMultiplicationTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Electromagnetism;

using FluentAssertions;

using Sundew.Quantities.AcceptanceTests.Testing;

using Xunit;

public class ResistanceMultiplicationTests
{
    [Theory]
    [InlineData(4, 2, 8)]
    [InlineData(4, 0, 0)]
    public void Resistance_Multiplication_Then_ResultIsExpected(double lhs, double rhs, double expected)
    {
        var resistance = new Resistance(lhs, units => units.Milli.Ohms);
        var eletricCurrent = new ElectricCurrent(rhs, units => units.Milli.Amperes);

        var result = resistance * eletricCurrent;

        result.Should().Be(expected, "μV");
    }
}