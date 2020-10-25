// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LuminousFluxDivisionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Photometry
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

    using Xunit;

    public class LuminousFluxDivisionTests
    {
        [Fact]
        public void LuminousFlux_Division_When_RhsIsArea_Then_ResultShouldBeExpected()
        {
            const double Expected = 8.6;
            var luminousFlux = 43.Lumens();
            var area = 5.SquareMeters();

            var result = luminousFlux / area;

            result.Should().Be(Expected, "lx");
        }
    }
}