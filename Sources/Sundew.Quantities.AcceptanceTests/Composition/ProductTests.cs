// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ProductTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Composition
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Photometry;

    using Xunit;

    public class ProductTests
    {
        [Fact]
        public void GetResult_Then_ResultShouldBeExpected()
        {
            const double Expected = 20;
            var luminousExposure = 5.Lux() * 4D.Seconds();

            var result = luminousExposure.GetResult();

            result.Should().Be(Expected, "lx*s");
        }

        [Fact]
        public void Multiplicand_Then_ResultShouldBeExpected()
        {
            const double Expected = 4;
            var luminousExposure = 5.Lux() * 4D.Seconds();

            var result = luminousExposure.Multiplicand;

            result.Should().Be(Expected, "s");
        }

        [Fact]
        public void Multiplier_Then_ResultShouldBeExpected()
        {
            const double Expected = 5;
            var luminousExposure = 5.Lux() * 4D.Seconds();

            var result = luminousExposure.Multiplier;

            result.Should().Be(Expected, "lx");
        }
    }
}