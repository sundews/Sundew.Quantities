// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResistanceTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests;

using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

public class ResistanceTests
{
    [Fact]
    public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
    {
        const string Input = "{\"Resistance\":{\"Value\":54.0,\"Unit\":\"μΩ\"}}";
        var expected = 54.ToResistance(units => units.Micro.Ohms);

        var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Resistance.ToQuantity();

        result.Should().Be(expected);
    }

    [Fact]
    public void SerializeObject_Then_ResultShouldShouldBeExpected()
    {
        const string Expected = "{\"Value\":45.0,\"Unit\":\"μΩ\"}";
        var testee = 45.ToResistance(units => units.Micro.Ohms).ToSerializable();

        var result = JsonConvert.SerializeObject(testee);

        result.Should().Be(Expected);
    }

    public class ConfigurationContainer
    {
        public Resistance Resistance { get; set; }
    }
}