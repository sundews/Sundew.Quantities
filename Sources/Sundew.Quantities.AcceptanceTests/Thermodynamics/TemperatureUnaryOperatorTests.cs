// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TemperatureUnaryOperatorTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Thermodynamics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

    using Xunit;

    public class TemperatureUnaryOperatorTests
    {
        [Fact]
        public void Temperature_Decrement_Then_ResultShouldBeMinusOne()
        {
            var testee = -43.Celsius();

            var result = ++testee;

            result.Should().Be(-42, "°C");
        }

        [Fact]
        public void Temperature_Increment_Then_ResultShouldBePlusOne()
        {
            var testee = 43.Celsius();

            var result = ++testee;

            result.Should().Be(44, "°C");
        }

        [Fact]
        public void Temperature_UnaryMinus_Then_ResultShouldBeNegated()
        {
            var testee = 43.Celsius();

            var result = -testee;

            result.Should().Be(-43, "°C");
        }
    }
}