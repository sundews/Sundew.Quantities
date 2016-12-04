// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DistanceDivisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class DistanceDivisionTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Distance_Division_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Distance(rhs, x => x.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Distance_Division_When_DividingWithAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Distance(lhs, x => x.Meters);

            var result = testee / rhs;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(10000, 50, 2)]
        public void Distance_Division_When_RhsIsVelocityAndPrefixesAreDifferent_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Distance(lhs, x => x.Centi.Meters);
            var testee2 = new Velocity(rhs, selector => selector.Meters / selector.Seconds);

            var result = testee1 / testee2;

            result.Should().BeApproximately(expected, "s", TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(50, 10, 5)]
        public void Distance_Division_When_RhsIsVelocity_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Velocity(rhs, selector => selector.Meters / selector.Seconds);

            var result = testee1 / testee2;

            result.Should().BeApproximately(expected, "s");
        }

        [Theory]
        [InlineData(50, 10, 5)]
        [InlineData(0, 10, 0)]
        [InlineData(40, 0, double.PositiveInfinity)]
        public void Distance_Division_When_RhsIsTime_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Time(rhs, x => x.Seconds);

            var result = testee1 / testee2;

            result.Should().BeApproximately(expected, "m/s");
        }
    }
}