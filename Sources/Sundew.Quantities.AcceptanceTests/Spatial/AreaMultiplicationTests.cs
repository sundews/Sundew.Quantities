// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AreaMultiplicationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class AreaMultiplicationTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 30.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -2000.0)]
        public void Area_Multiplication_When_MultiplyingWithAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Area(lhs, x => x.Square.Meters);

            var result = testee1 * rhs;

            result.Should().Be(expected, "m²");
        }

        [Theory]
        [InlineData(1000.0, 1.0, 1609344)]
        public void Area_Multiplication_When_MultiplyingWithAnyLength_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Area(lhs, x => x.Square.Meters);
            var length = new Distance(rhs, x => x.Miles);

            var result = testee * length;

            result.Should().Be(expected, "m³");
        }
    }
}