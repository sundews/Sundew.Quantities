// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ForceTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Newtonsoft.Json;

    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.Serialization.Poco.Mechanics;

    using Xunit;

    public class ForceTests
    {
        public class ConfigurationContainer
        {
            public Poco.Mechanics.Force Force { get; set; }
        }

        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Force\":{\"Value\":54.0,\"Unit\":\"N\"}}";
            var expected = 54.Newtons();

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Force.ToQuantity();

            result.Should().Be(expected);
        }

        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":5.0,\"Unit\":\"N\"}";
            var testee = 5.Newtons().ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }
    }
}