// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TemperatureTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests
{
    public class TemperatureTests
    {
        public class ConfigurationContainer
        {
            public Temperature Temperature { get; set; }
        }

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
    }
}