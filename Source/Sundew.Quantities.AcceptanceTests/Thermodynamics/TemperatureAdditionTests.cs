// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureAdditionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Thermodynamics;

using FluentAssertions;

using Sundew.Quantities.AcceptanceTests.Testing;

using Xunit;

public class TemperatureAdditionTests
{
    [Fact]
    public void Temperature_Addition_Then_ResultShouldBeSummed()
    {
        var lhs = 43.Celsius();
        var rhs = 32.Celsius();

        var result = lhs + rhs;

        result.Should().Be(75, "°C");
    }
}