﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivedUnitTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Units;

using FluentAssertions;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Units;
using Xunit;

public class DerivedUnitTests
{
    private static readonly Unit MeterUnit = new("m");

    private static readonly Expression CentiMeterUnitExpression = new UnitExpression(MeterUnit.GetPrefixedUnit(Prefixes.Centi));

    [Theory]
    [InlineData("cm²", "cm²")]
    [InlineData(null, "cm*cm")]
    public void GetNotationWithoutPrefix_Then_ResultShouldBeExpected(string notation, string expected)
    {
        var testee = new DerivedUnit(notation, CentiMeterUnitExpression * CentiMeterUnitExpression);

        var result = testee.GetNotationWithoutPrefix();

        result.Should().Be(expected);
    }

    [Fact]
    public void CompositeUnitDivision_When_PrefixesAreDifferent_Then_NotationShouldBeRhsPrefixSquared()
    {
        var testee = new DerivedUnit(null, MeterUnit / CentiMeterUnitExpression);

        testee.ToString().Should().Be("m/cm");
    }

    [Fact]
    public void CompositeUnitMultiplication_When_PrefixesAreDifferent_Then_NotationShouldBeLhsPrefixTimesRhsPrefix()
    {
        var testee = new DerivedUnit(null, MeterUnit * CentiMeterUnitExpression);

        testee.ToString().Should().Be("m*cm");
    }
}