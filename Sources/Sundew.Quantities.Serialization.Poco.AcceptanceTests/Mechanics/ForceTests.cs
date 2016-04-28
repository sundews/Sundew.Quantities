namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Newtonsoft.Json;

    using Poco.Mechanics;

    using Sundew.Quantities.Mechanics;

    using Xunit;

    public class ForceTests
    {
        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":5.0,\"Unit\":\"N\"}";
            var testee = 5.Newtons().ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }

        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Force\":{\"Value\":54.0,\"Unit\":\"N\"}}";
            var expected = 54.Newtons();

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Force.ToQuantity();

            result.Should().Be(expected);
        }
        
        public class ConfigurationContainer
        {
            public Serialization.Poco.Mechanics.Force Force { get; set; }
        }
    }
}