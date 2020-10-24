// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DistanceSubtractionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

    using Xunit;

    public class DistanceSubtractionTests
    {
        [Theory]
        [InlineData(3.0, 1000.0, -7.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 4000.0, -90.0)]
        public void Distance_Subtraction_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Distance(rhs, x => x.Centi.Meters);

            var result = testee1 - testee2;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(3.0, 10.0, -7.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -90.0)]
        public void Distance_Subtraction_When_SubtractingAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Distance(lhs, x => x.Meters);

            var result = testee - rhs;

            result.Should().Be(expected, "m");
        }
    }
}