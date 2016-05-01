// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitHelperTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Units
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class UnitHelperTests
    {
        [Fact]
        public void AreUnitsEqual_When_UnitsArePrefixedBaseUnitAndPrefixedUnitOfKg_Then_ResultShouldBeTrue()
        {
            var prefixedBaseUnitKg = UnitDefinitions.KiloGram;
            var prefixedUnitKg = UnitDefinitions.Gram.GetPrefixedUnit(Prefixes.Kilo);

            var result = UnitHelper.AreUnitsEqual(prefixedBaseUnitKg, prefixedUnitKg);

            result.Should().BeTrue();
        }
    }
}