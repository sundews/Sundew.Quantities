// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatRepresentationBuilderTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Flat;

using System.Collections.Generic;
using FluentAssertions;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;
using Sundew.Quantities.Representations.Units;
using Xunit;

public class FlatRepresentationBuilderTests
{
    private readonly FlatRepresentationBuilder testee;

    private readonly Dictionary<string, UnitFlatIdentifierRepresentation> unitFlatIdentifierRepresentations;

    public FlatRepresentationBuilderTests()
    {
        this.unitFlatIdentifierRepresentations = new Dictionary<string, UnitFlatIdentifierRepresentation>();
        this.testee = new FlatRepresentationBuilder(this.unitFlatIdentifierRepresentations);
    }

    [Theory]
    [InlineData("s", 1)]
    [InlineData("m", -2)]
    public void Add_Then_DictionaryShouldContainUnitWithExponent(string variable, double exponent)
    {
        this.testee.Add(new UnitExpression(new Unit(variable)), false, exponent);

        this.unitFlatIdentifierRepresentations.Should()
            .ContainKey(variable)
            .WhoseValue.Exponent.Should()
            .Be(exponent);
    }

    [Theory]
    [InlineData(false, "km", -1)]
    [InlineData(true, "m", 1)]
    public void Add_When_AddingPrefixedUnitAndBaseUnitHasAlreadyBeenAdded_Then_ExponentShouldBeAccumulated(
        bool reduceUsingBaseUnits,
        string expectedUnit,
        double expectedExponent)
    {
        this.testee.Add(new UnitExpression(new Unit("m")), false, 2);

        this.testee.Add(new UnitExpression(new Unit("m").GetPrefixedUnit(Prefixes.Kilo)), reduceUsingBaseUnits, -1);

        this.unitFlatIdentifierRepresentations.Should()
            .ContainKey(expectedUnit)
            .WhoseValue.Exponent.Should()
            .Be(expectedExponent);
    }

    [Theory]
    [InlineData("var", 1)]
    [InlineData("var2", -2)]
    public void Build_When_VariableHasBeAdded_Then_ResultShouldContainVariableWithExponent(
        string variable,
        double exponent)
    {
        var expected = FlatUnit.CreateFlatRepresentation(new FlatVariable(variable, exponent));
        this.testee.Add(new VariableExpression(variable), exponent);

        var result = this.testee.Build();

        result.Should().ContainInOrder(expected);
    }

    [Theory]
    [InlineData(10, 1)]
    [InlineData(40, -2)]
    public void Build_When_ConstantHasBeAdded_Then_ResultShouldContainVariableWithExponent(
        double constant,
        double exponent)
    {
        var expected = FlatUnit.CreateFlatRepresentation(new FlatConstant(constant, exponent));
        this.testee.Add(new ConstantExpression(constant), exponent);

        var result = this.testee.Build();

        result.Should().ContainInOrder(expected);
    }

    [Fact]
    public void Add_When_UnitHasPreviouslyBeenAdded_Then_ExponentShouldBeAccumulated()
    {
        this.testee.Add(new UnitExpression(new Unit("m")), false, 2);

        this.testee.Add(new UnitExpression(new Unit("m")), false, -1);

        this.unitFlatIdentifierRepresentations.Should().ContainKey("m").WhoseValue.Exponent.Should().Be(1);
    }

    [Fact]
    public void Build_When_MultipleConstantsHaveBeenBeenAdded_Then_ExponentShouldBeMultipled()
    {
        var expected = FlatUnit.CreateFlatRepresentation(new FlatConstant(16, 1));
        this.testee.Add(new ConstantExpression(2), 2);
        this.testee.Add(new ConstantExpression(4), 1);

        var result = this.testee.Build();

        result.Should().ContainInOrder(expected);
    }

    [Fact]
    public void Build_When_MultipleVariablesHavesBeenBeenAdded_Then_ExponentShouldBeAccumulated()
    {
        var expected = FlatUnit.CreateFlatRepresentation(new FlatVariable("var", 3));
        this.testee.Add(new VariableExpression("var"), 2);
        this.testee.Add(new VariableExpression("var"), 1);

        var result = this.testee.Build();

        result.Should().ContainInOrder(expected);
    }
}