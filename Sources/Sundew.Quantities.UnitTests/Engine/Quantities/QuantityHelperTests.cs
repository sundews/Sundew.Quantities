// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityHelperTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Quantities
{
    using System.Linq;

    using FluentAssertions;

    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class QuantityHelperTests
    {
        [Theory]
        [InlineData(5, "km", 5000, "m", true)]
        [InlineData(3, "m", 4, "m", false)]
        [InlineData(5, "m", 5, "m", true)]
        [InlineData(5, "m", 5, "s", false)]
        public void AreEqual_Then_ResultShouldBeExpected(
            double lhs,
            string lhsUnit,
            double rhs,
            string rhsUnit,
            bool expected)
        {
            var testee1 = new Quantity(lhs, GetUnit(lhsUnit));
            var testee2 = new Quantity(rhs, GetUnit(rhsUnit));

            var result = QuantityHelper.AreEqual(testee1, testee2);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 3, false)]
        [InlineData(5, 18, true)]
        public void AreEqual_When_ComparingTwoCompatibleUnits_Then_ResultShouldBeExpected(
            double lhs,
            double rhs,
            bool expected)
        {
            var testee1 = new Quantity(lhs, UnitDefinitions.Velocity);
            var testee2 = new Quantity(
                rhs,
                new DerivedUnit(
                    string.Empty,
                    Prefixes.Kilo * UnitDefinitions.Meter / UnitDefinitions.Hour.GetExpression()));

            var result = QuantityHelper.AreEqual(testee1, testee2);

            result.Should().Be(expected);
        }

        private static IUnit GetUnit(string lhsUnit)
        {
            var unit = new Unit(lhsUnit.Cast<char>().Last().ToString());
            if (lhsUnit.Length == 2)
            {
                var notation = lhsUnit[0].ToString();
                return unit.GetPrefixedUnit(new FactoredPrefix(notation, 1000, notation));
            }

            return unit;
        }
    }
}