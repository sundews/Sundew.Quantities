// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DistanceEqualityTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Xunit;

    public class DistanceEqualityTests
    {
        [Theory]
        [InlineData(4.0, 4.0, true)]
        [InlineData(4.0, 5.0, false)]
        public void Distance_Equals_Then_ResultShouldBeAsExpected(double lhs, double rhs, bool expected)
        {
            var testee1 = new Distance(lhs, x => x.Miles);
            var testee2 = new Distance(rhs, x => x.Miles);

            var result = testee1.Equals(testee2);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(4.0, 1, 4.0, 1, true)]
        [InlineData(4.0, 1000, 4.0, 1000, true)]
        [InlineData(4.0, 1, 5.0, 1, false)]
        [InlineData(4.0, 1000, 4.0, 1, false)]
        public void Distance_Equals_When_PrefixesAreDifferent_Then_ResultShouldBeAsExpected(
            double lhs,
            double lhsPrefix,
            double rhs,
            double rhsPrefix,
            bool expected)
        {
            var testee1 = new Distance(lhs, x => x.By(lhsPrefix).Meters);
            var testee2 = new Distance(rhs, x => x.By(rhsPrefix).Meters);

            var result = testee1.Equals(testee2);

            result.Should().Be(expected);
        }

        /*  [Theory]
        [InlineData(4.0, 1, 1, 4.0)]
        [InlineData(4.0, 1000, 1, 4000.0)]
        [InlineData(8.0, 1, 1000, 8000.0)]
        [InlineData(16.0, 0.5, 1000, 8000.0)]
        public void GetHashCode_Then_ResultShouldBeExpectedHashCodeSourcesHashCode(double length, double prefix, double unitFactor, double expectedHashCodeSource)
        {
            var testee = new Distance(length, x => x.By(prefix).WithFactor(unitFactor));

            var result = testee.GetHashCode();

            result.Should().Be(expectedHashCodeSource.GetHashCode());
        }*/
    }
}