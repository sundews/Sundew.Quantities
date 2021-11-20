// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PotentialAdditionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Electromagnetism;

using FluentAssertions;
using Sundew.Quantities.AcceptanceTests.Testing;
using Sundew.Quantities.Core;
using Xunit;

public class PotentialAdditionTests
{
    [Fact]
    public void Potential_Add_Then_ResultShouldBeExpected()
    {
        var lhs = new Potential(5, units => units.Milli.Volts);
        var rhs = new Potential(5000, units => units.Micro.Volts);

        var result = lhs + rhs;

        result.Should().Be(10, "mV", UnitFormat.Default);
    }
}