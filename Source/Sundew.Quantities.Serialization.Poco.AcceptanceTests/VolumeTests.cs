﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VolumeTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco.AcceptanceTests;

using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

public class VolumeTests
{
    [Fact]
    public void DeserializeObject_When_QuantityIsNested_Then_ResultShouldShouldBeExpected()
    {
        const string Input = "{\"Volume\":{\"Value\":54.0,\"Unit\":\"μL\"}}";
        var expected = 54.ToVolume(units => units.Micro.Liters);

        var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Volume.ToQuantity();

        result.Should().Be(expected);
    }

    [Fact]
    public void DeserializeObject_When_UnitIsCubicMicroMetersAndQuantityIsNested_Then_ResultShouldShouldBeExpected()
    {
        const string Input = "{\"Volume\":{\"Value\":54.0,\"Unit\":\"μm³\"}}";
        var expected = 54.ToVolume(units => units.Cubic.Micro.Meters);

        var result = JsonConvert.DeserializeObject<ConfigurationContainer>(Input).Volume.ToQuantity();

        result.Should().Be(expected);
    }

    [Fact]
    public void SerializeObject_Then_ResultShouldShouldBeExpected()
    {
        const string Expected = "{\"Value\":5.0,\"Unit\":\"L\"}";
        var testee = 5.Liters().ToSerializable();

        var result = JsonConvert.SerializeObject(testee);

        result.Should().Be(Expected);
    }

    [Fact]
    public void SerializeObject_WhenUnitIsCubicMeters_Then_ResultShouldShouldBeExpected()
    {
        const string Expected = "{\"Value\":5.0,\"Unit\":\"m³\"}";
        var testee = 5.ToVolume(units => units.Cubic.Meters).ToSerializable();

        var result = JsonConvert.SerializeObject(testee);

        result.Should().Be(Expected);
    }

    public class ConfigurationContainer
    {
        public Volume Volume { get; set; }
    }
}