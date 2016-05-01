// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityOperationsTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Operations
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class QuantityOperationsTests
    {
        [Theory]
        [InlineData(0, -459.67)]
        [InlineData(273.15, 32)]
        [InlineData(373.15, 212)]
        public void ConvertToUnit_WhenConvertingKelvinToFahrenheit_When_ResultShouldBeExpected(
            double kelvin,
            double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(kelvin, UnitDefinitions.Kelvin),
                UnitDefinitions.Fahrenheit);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(-459.67, 0)]
        [InlineData(32, 273.15)]
        [InlineData(212, 373.15)]
        public void ConvertToUnit_WhenConvertingFahrenheitToKelvin_When_ResultShouldBeExpected(
            double fahrenheit,
            double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(fahrenheit, UnitDefinitions.Fahrenheit),
                UnitDefinitions.Kelvin);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(-459.67, -273.15)]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        public void ConvertToUnit_WhenConvertingFahrenheitToCelsius_When_ResultShouldBeExpected(
            double fahrenheit,
            double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(fahrenheit, UnitDefinitions.Fahrenheit),
                UnitDefinitions.Celsius);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(-273.15, -459.67)]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        public void ConvertToUnit_WhenConvertingCelsiusToFahrenheit_When_ResultShouldBeExpected(
            double celsuis,
            double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(celsuis, UnitDefinitions.Celsius),
                UnitDefinitions.Fahrenheit);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(0, -273.15)]
        [InlineData(273.15, 0)]
        [InlineData(373.15, 100)]
        public void ConvertToUnit_WhenConvertingKelvinToCelsius_When_ResultShouldBeExpected(
            double kelvin,
            double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(kelvin, UnitDefinitions.Kelvin),
                UnitDefinitions.Celsius);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(-273.15, 0)]
        [InlineData(0, 273.15)]
        [InlineData(100, 373.15)]
        public void ConvertToUnit_WhenConvertingCelsiusToKelvin_When_ResultShouldBeExpected(
            double celsius,
            double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(celsius, UnitDefinitions.Celsius),
                UnitDefinitions.Kelvin);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(-10000, -6.21371192237334)]
        [InlineData(0, 0)]
        [InlineData(10000, 6.21371192237334)]
        public void ConvertToUnit_WhenConvertingMeterToMiles_When_ResultShouldBeExpected(double meter, double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(meter, UnitDefinitions.Meter),
                UnitDefinitions.Mile);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }

        [Theory]
        [InlineData(-6.21371192237334, -10000)]
        [InlineData(0, 0)]
        [InlineData(6.21371192237334, 10000)]
        public void ConvertToUnit_WhenConvertingMilesToMeter_When_ResultShouldBeExpected(double miles, double expected)
        {
            var result = QuantityOperations.ConvertToUnit(
                new Quantity(miles, UnitDefinitions.Mile),
                UnitDefinitions.Meter);

            result.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }
    }
}