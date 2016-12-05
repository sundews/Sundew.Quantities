// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="CustomUnitTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests
{
    using FluentAssertions;
    using Newtonsoft.Json;
    using Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit;
    using Xunit;

    public class CustomUnitTests
    {
        public class ConfigurationContainer
        {
            public Distance Distance { get; set; }
        }

        [Fact]
        public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
        {
            const string Input = "{\"Distance\":{\"Value\":54.0,\"Unit\":\"1.87152645391975E-05*m\"}}";
            var expected = 54.ToDistance(units => units.Steps());

            var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Distance.ToQuantity();

            result.Should().Be(expected);
        }

        [Fact]
        public void SerializeObject_Then_ResultShouldShouldBeExpected()
        {
            const string Expected = "{\"Value\":5.0,\"Unit\":\"1.87152645391975E-05*m\"}";
            var testee = 5.ToDistance(units => units.Steps()).ToSerializable();

            var result = JsonConvert.SerializeObject(testee);

            result.Should().Be(Expected);
        }
    }
}