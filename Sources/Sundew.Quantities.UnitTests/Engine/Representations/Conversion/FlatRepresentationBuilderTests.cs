// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatRepresentationBuilderTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;
using Sundew.Quantities.Representations.Units;

namespace Sundew.Quantities.UnitTests.Engine.Representations.Conversion
{
    using System.Collections.Generic;

    using FluentAssertions;
    using Sundew.Quantities.UnitTests.Engine.Representations.Flat;

    using Xunit;

    public class FlatRepresentationBuilderTests
    {
        public FlatRepresentationBuilderTests()
        {
            this.unitFlatIdentifierRepresentations = new Dictionary<string, UnitFlatIdentifierRepresentation>();
            this.testee = new FlatRepresentationBuilder(this.unitFlatIdentifierRepresentations);
        }

        private readonly FlatRepresentationBuilder testee;

        private readonly Dictionary<string, UnitFlatIdentifierRepresentation> unitFlatIdentifierRepresentations;

        [Theory]
        [InlineData("s", 1)]
        [InlineData("m", -2)]
        public void Add_Then_DictionaryShouldContainUnitWithExponent(string variable, double exponent)
        {
            this.testee.Add(new UnitExpression(new Unit(variable)), false, exponent);

            this.unitFlatIdentifierRepresentations.Should()
                .ContainKey(variable)
                .WhichValue.Exponent.Should()
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
                .WhichValue.Exponent.Should()
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

            this.unitFlatIdentifierRepresentations.Should().ContainKey("m").WhichValue.Exponent.Should().Be(1);
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
}