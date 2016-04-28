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