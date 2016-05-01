// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SpatialExtensionsTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Spatial;

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
}