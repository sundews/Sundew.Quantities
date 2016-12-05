// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ChargeMultiplicationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
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