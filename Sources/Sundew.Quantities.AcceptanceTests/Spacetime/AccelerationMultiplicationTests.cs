// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AccelerationMultiplicationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spacetime
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

    using Xunit;

    public class AccelerationMultiplicationTests
    {
        [Theory]
        [InlineData(20, 1, 20.0)]
        [InlineData(23.0, 0.0, 0.0)]
        [InlineData(0.0, 4.0, 0.0)]
        [InlineData(20, 1.5, 30.0)]
        public void Acceleration_Multiplication_Then_ResultShouldBeExpected(double lhs, double rhs, double expected)
        {
            var testee = new Acceleration(lhs, x => x.Kilo.Meters / x.Hours / x.Hours);
            var time = new Time(rhs, x => x.Hours);

            var result = testee * time;

            result.Should().Be(expected, "km/h");
        }
    }
}