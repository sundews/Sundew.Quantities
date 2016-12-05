// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AreaDivisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations.Internals;

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class AreaDivisionTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Area_Division_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Area(lhs, x => x.Meters * x.Meters);
            var testee2 = new Area(rhs, x => x.Meters * x.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(576, 0.03, 19.2)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -0.00125)]
        public void Area_Division_When_RhsIsLength_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Area(lhs, x => x.Meters * x.Meters);
            var testee2 = new Distance(rhs, x => x.Kilo.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected, "m");
        }

        [Theory]
        [InlineData(8, 2000, 4)]
        public void Area_Division_When_LhsIsSquareKiloMeter_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Area(lhs, x => x.Square.Kilo.Meters);
            var testee2 = new Distance(rhs, x => x.Meters);

            var result = testee1 / testee2;

            result.Should().Be(expected, "km");
        }

        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Area_Division_When_DividingWithAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Area(lhs, x => x.Meters * x.Meters);

            var result = testee / rhs;

            result.Should().Be(expected, "m" + Constants.Exponent2);
        }

        [Theory]
        [InlineData(2, 50, 0.4)]
        public void Area_Division_When_RhsIsLengthAndPrefixesAreDifferent_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Area(lhs, x => x.Square.Deci.Meters);
            var testee2 = new Distance(rhs, x => x.Centi.Meters);

            var result = testee1 / testee2;

            result.Should().BeApproximately(expected, "dm", TestHelper.DefaultAssertPrecision);
        }
    }
}