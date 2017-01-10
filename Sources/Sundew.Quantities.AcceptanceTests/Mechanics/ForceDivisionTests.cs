// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForceDivisionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
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