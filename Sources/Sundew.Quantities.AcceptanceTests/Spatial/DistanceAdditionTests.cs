// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DistanceAdditionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class DistanceAdditionTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 13.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -10.0)]
        public void Distance_Addition_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Distance(lhs, x => x.Meters);
            var testee2 = new Distance(rhs, x => x.Meters);

            var result = testee1 + testee2;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(3.0, 10.0, 13.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -10.0)]
        public void Distance_Addition_When_AddingAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Distance(lhs, x => x.Meters);

            var result = testee + rhs;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(3.0, 10.0, 3.010)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -49.96)]
        public void Distance_Addition_When_PrefixesAreDifferent_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Distance(lhs, x => x.Kilo.Meters);
            var testee2 = new Distance(rhs, x => x.Meters);

            var result = testee1 + testee2;

            result.Should().Be(expected, "km");
        }

        [Theory]
        [InlineData(4.0, 4.0, 6.48548476894934)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(80.0, -90.0, 24.0765926986399)]
        public void Distance_Addition_When_UnitsAreDifferent_Then_ResultShouldBeAsExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Distance(lhs, x => x.Miles);
            var testee2 = new Distance(rhs, x => x.Kilo.Meters);

            var result = testee1 + testee2;

            result.Should().BeApproximately(expected, "mi", TestHelper.DefaultAssertPrecision);
        }
    }
}