// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassUnitSelectorTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.UnitSelector
{
    using FluentAssertions;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.Representations.Units;
    using Sundew.Quantities.UnitSelectors;
    using Xunit;

    public class MassUnitSelectorTests
    {
        private readonly MassUnitSelector testee = new();

        [Fact]
        public void KiloGramBuildUnit_Then_ResultShouldBePrefixedBaseUnit()
        {
            var result = UnitBuilder.BuildUnit(this.testee.KiloGrams);

            result.Should().BeOfType<PrefixedBaseUnit>();
        }

        [Fact]
        public void KiloGramUnitNotation_When_UsingPrefixSelector_Then_ResultShouldBePrefixedBaseUnit()
        {
            var result = UnitBuilder.BuildUnit(this.testee.Kilo.Grams).BaseUnit;

            result.Should().Be(UnitDefinitions.KiloGram);
        }
    }
}