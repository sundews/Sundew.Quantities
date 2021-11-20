// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpatialExtensionsTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests;

using FluentAssertions;

using Sundew.Quantities.AcceptanceTests.Testing;

using Xunit;

public class SpatialExtensionsTests
{
    [Fact]
    public void Meters_Then_ResultShouldBe4m()
    {
        var result = 4.Meters();

        result.Should().Be(4, "m");
    }

    [Fact]
    public void Meters_Then_ResultShouldBe9p2m()
    {
        var result = 9.2.Meters();

        result.Should().Be(9.2, "m");
    }
}