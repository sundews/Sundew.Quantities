namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Newtonsoft.Json;

    using Poco.Spatial;

    using Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class CustomUnitTests
    {
        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":5.0,\"Unit\":\"1.87152645391975E-05*m\"}";
            var testee = 5.ToDistance(units => units.Steps()).ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }

        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Distance\":{\"Value\":54.0,\"Unit\":\"1.87152645391975E-05*m\"}}";
            var expected = 54.ToDistance(units => units.Steps());

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Distance.ToQuantity();

            result.Should().Be(expected);
        }

        public class ConfigurationContainer
        {
            public Poco.Spatial.Distance Distance { get; set; }
        }
    }
}