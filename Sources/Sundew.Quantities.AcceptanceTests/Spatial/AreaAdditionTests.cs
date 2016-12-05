// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AreaAdditionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class AreaAdditionTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 13.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -10.0)]
        public void Area_Addition_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Area(lhs, x => x.Kilo.Meters * x.Kilo.Meters);
            var testee2 = new Area(rhs, x => x.Kilo.Meters * x.Kilo.Meters);

            IQuantity result = testee1 + testee2;

            result.Value.Should().Be(expected);
        }

        [Theory]
        [InlineData(3.0, 10.0, 13.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40.0, -10.0)]
        public void Area_Addition_When_AddingAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Area(lhs, x => x.Square.Kilo.Meters);

            var result = testee + rhs;

            result.Should().Be(expected, "km²");
        }

        [Theory]
        [InlineData(3.0, 10000000.0, 13)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-50.0, 40000000.0, -10)]
        public void Area_Addition_When_PrefixesAreDifferent_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Area(lhs, x => x.Kilo.Meters * x.Kilo.Meters);
            var testee2 = new Area(rhs, x => x.Meters * x.Meters);

            var result = testee1 + testee2;

            result.Should().Be(expected, "km²");
        }

        [Theory]
        [InlineData(4.0, 4.0, 5.5444086341697)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(80.0, -90.0, 45.2508057311799)]
        public void Area_Addition_When_UnitsAreDifferent_Then_ResultBeApproximatelyExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Area(lhs, x => x.Miles * x.Miles);
            var testee2 = new Area(rhs, x => x.Kilo.Meters * x.Kilo.Meters);

            var result = testee1 + testee2;

            result.Should().BeApproximately(expected, "mi²", TestHelper.DefaultAssertPrecision);
        }

        [Fact]
        public void Area_Addition_Then_ResultUnitShouldBe_km2()
        {
            var testee1 = new Area(0, x => x.Kilo.Meters * x.Kilo.Meters);
            var testee2 = new Area(0, x => x.Kilo.Meters * x.Kilo.Meters);

            var result = testee1 + testee2;

            result.Unit.ToString().Should().Be("km²");
        }
    }
}