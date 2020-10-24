// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityMultiplicationTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;
    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.Parsing;
    using Xunit;

    public class QuantityMultiplicationTests
    {
        [Theory]
        [InlineData(3, "s", 4, "A", UnitFormat.Default, 12, "C")]
        public void Quantity_Multiplication_Then_ResultShouldBeExpected(
            double lhs,
            string lhsUnit,
            double rhs,
            string rhsUnit,
            UnitFormat unitFormat,
            double expectedValue,
            string expectedUnit)
        {
            var testee1 = new Quantity(
                lhs,
                UnitSystem.GetUnitFrom(lhsUnit, ParseSettings.DefaultInvariantCulture).Value);
            var testee2 = new Quantity(
                rhs,
                UnitSystem.GetUnitFrom(rhsUnit, ParseSettings.DefaultInvariantCulture).Value);

            var result = testee1 * testee2;

            result.Should().Be(expectedValue, expectedUnit, unitFormat);
        }
    }
}