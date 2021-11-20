// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrequencyTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Periodics;

using FluentAssertions;
using Sundew.Quantities.AcceptanceTests.Testing;
using Sundew.Quantities.Core;
using Xunit;

public class FrequencyTests
{
    [Theory]
    [InlineData(3, 3000000)]
    [InlineData(0, 0)]
    public void Frequency_ToUnit_Then_ResultShouldBeExpected(double value, double expected)
    {
        var testee = new Frequency(value, x => x.Mega.Hertz);

        var result = testee.ToUnit(x => x.Hertz);

        result.Should().Be(expected, "Hz", UnitFormat.Default);
    }
}