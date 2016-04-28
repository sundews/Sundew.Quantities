namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests.Thermodynamics
{
    using FluentAssertions;

    using Newtonsoft.Json;
    using Poco.Thermodynamics;
    using Sundew.Quantities.Thermodynamics;

    using Xunit;

    public class TemperatureTests
    {
        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":5.0,\"Unit\":\"°C\"}";
            var testee = 5.Celsius().ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }

        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Temperature\":{\"Value\":54.0,\"Unit\":\"°C\"}}";
            var expected = 54.ToTemperature(units => units.Celsius);

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Temperature.ToQuantity();

            result.Should().Be(expected);
        }

        public class ConfigurationContainer
        {
            public Poco.Thermodynamics.Temperature Temperature { get; set; }
        }
    }
}