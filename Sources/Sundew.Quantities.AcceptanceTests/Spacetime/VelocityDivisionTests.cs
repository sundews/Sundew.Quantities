// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="VelocityDivisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Internals;

    using Xunit;

    public class VelocityDivisionTests
    {
        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Velocity_Division_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee1 = new Velocity(lhs, selector => selector.Meters / selector.Seconds);
            var testee2 = new Velocity(rhs, selector => selector.Meters / selector.Seconds);

            var result = testee1 / testee2;

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(576, 0.03, 19200)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Velocity_Division_When_RhsIsLength_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee1 = new Velocity(lhs, selector => selector.Meters / selector.Seconds);
            var testee2 = new Time(rhs, x => x.Seconds);

            var result = testee1 / testee2;

            result.Should().Be(expected, "m/s" + Constants.Exponent2);
        }

        [Theory]
        [InlineData(3.0, 10.0, 0.3)]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(0.0, 0.0, double.NaN)]
        [InlineData(-50.0, 40.0, -1.25)]
        public void Velocity_Division_When_DividingWithAnyNumber_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            double expected)
        {
            var testee = new Velocity(lhs, selector => selector.Meters / selector.Seconds);

            var result = testee / rhs;

            result.Should().Be(expected, "m/s");
        }
    }
}