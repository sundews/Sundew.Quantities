// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitHelperTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Units;

namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Units
{
    using FluentAssertions;
    using Xunit;

    public class UnitHelperTests
    {
        [Fact]
        public void AreUnitsEqual_When_UnitsArePrefixedBaseUnitAndPrefixedUnitOfKg_Then_ResultShouldBeTrue()
        {
            var prefixedBaseUnitKg = UnitDefinitions.KiloGram;
            var prefixedUnitKg = UnitDefinitions.Gram.GetPrefixedUnit(Prefixes.Kilo);

            var result = UnitEqualityHelper.AreUnitsEqual(prefixedBaseUnitKg, prefixedUnitKg);

            result.Should().BeTrue();
        }
    }
}