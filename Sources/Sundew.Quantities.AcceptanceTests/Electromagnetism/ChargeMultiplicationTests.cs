// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChargeMultiplicationTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;
    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Core;
    using Xunit;

    public class ChargeMultiplicationTests
    {
        [Fact]
        public void Charge_Multiplication_Then_ResultShouldBeExpected()
        {
            var testee = new Charge(3, x => x.Coulombs);
            var potential = new Potential(4, x => x.Volts);

            var result = testee * potential;

            result.Should().Be(12, "J", UnitFormat.Default);
        }
    }
}