// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ForceDivisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

    using Xunit;

    public class ForceDivisionTests
    {
        [Fact]
        public void Force_Division_When_RhsIsArea_Then_ResultShouldBeExpected()
        {
            const double Expected = 8.6;
            var force = 43.Newtons();
            var area = 5.SquareMeters();

            var result = force / area;

            result.Should().Be(Expected, "Pa");
        }
    }
}