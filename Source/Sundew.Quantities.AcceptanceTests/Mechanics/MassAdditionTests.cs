// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassAdditionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class MassAdditionTests
    {
        [Theory]
        [InlineData(100, 10, 383.49523124984256)]
        public void Mass_Addition_When_LhsIsGramAndRhsIsOunce_ThenResultShouldBeExpected(
            double lhsValue,
            double rhsValue,
            double expected)
        {
            var lhs = new Mass(lhsValue, units => units.Grams);
            var rhs = new Mass(rhsValue, units => units.Ounces);

            var result = lhs + rhs;

            result.Should().BeApproximately(expected, "g", TestHelper.DefaultAssertPrecision);
        }
    }
}