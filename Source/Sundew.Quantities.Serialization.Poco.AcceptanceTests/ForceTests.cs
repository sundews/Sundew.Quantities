// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForceTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests;

using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

public class ForceTests
{
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

    public class ConfigurationContainer
    {
        public Force Force { get; set; }
    }
}