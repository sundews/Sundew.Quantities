namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;

    using Newtonsoft.Json;

    using Sundew.Quantities.Electromagnetism;
    using Sundew.Quantities.Serialization.Poco.Electromagnetism;

    using Xunit;

    public class ResistanceTests
    {
        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":45.0,\"Unit\":\"μΩ\"}";
            var testee = 45.ToResistance(units => units.Micro.Ohms).ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }

        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Resistance\":{\"Value\":54.0,\"Unit\":\"μΩ\"}}";
            var expected = 54.ToResistance(units => units.Micro.Ohms);

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Resistance.ToQuantity();

            result.Should().Be(expected);
        }

        public class ConfigurationContainer
        {
            public Poco.Electromagnetism.Resistance Resistance { get; set; }
        }
    }
}