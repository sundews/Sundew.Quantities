// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests
{
    using FluentAssertions;
    using Newtonsoft.Json;
    using Xunit;

    public class TemperatureTests
    {
        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Temperature\":{\"Value\":54.0,\"Unit\":\"°C\"}}";
            var expected = 54.ToTemperature(units => units.Celsius);

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Temperature.ToQuantity();

            result.Should().Be(expected);
        }

        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":5.0,\"Unit\":\"°C\"}";
            var testee = 5.Celsius().ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }

        public class ConfigurationContainer
        {
            public Temperature Temperature { get; set; }
        }
    }
}