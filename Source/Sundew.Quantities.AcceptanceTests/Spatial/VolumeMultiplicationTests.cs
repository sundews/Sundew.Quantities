// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VolumeMultiplicationTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial;

using FluentAssertions;
using Sundew.Quantities.AcceptanceTests.Testing;
using Sundew.Quantities.Representations.Internals;
using Xunit;

public class VolumeMultiplicationTests
{
    [Theory]
    [InlineData(3.0, 10.0, 30.0)]
    [InlineData(0.0, 0.0, 0.0)]
    [InlineData(-50.0, 40.0, -2000.0)]
    public void Volume_Multiplication_When_MultiplyingWithAnyNumber_Then_ResultShouldBeExpected(
        double lhs,
        double rhs,
        double expected)
    {
        var testee1 = new Volume(lhs, x => x.Cubic.Meters);

        var result = testee1 * rhs;

        result.Should().Be(expected, "m" + Constants.Exponent3);
    }
}