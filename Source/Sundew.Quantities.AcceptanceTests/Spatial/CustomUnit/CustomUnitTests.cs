// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomUnitTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial;

using FluentAssertions;
using Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit;
using Sundew.Quantities.AcceptanceTests.Testing;
using Sundew.Quantities.Core;
using Sundew.Quantities.Representations.Units;
using Sundew.Quantities.UnitTests;
using Xunit;

public class CustomUnitTests : StepsTestBase
{
    [Fact]
    public void CustomUnitToUnit_Then_ResultShouldBeExpected()
    {
        var steps = new Quantity(43, this.StepsUnit);
        const double Expected = 0.00080475637518549213354573461734671;

        var result = steps.ToUnit(UnitDefinitions.Meter);

        result.Should().BeApproximately(Expected, "m", TestHelper.DefaultAssertPrecision);
    }
}