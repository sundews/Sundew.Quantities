// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitEqualityHelperTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Representations.Expressions
{
    using FluentAssertions;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class UnitEqualityHelperTests
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