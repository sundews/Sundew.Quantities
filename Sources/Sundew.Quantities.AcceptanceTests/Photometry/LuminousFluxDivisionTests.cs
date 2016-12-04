// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousFluxDivisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

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