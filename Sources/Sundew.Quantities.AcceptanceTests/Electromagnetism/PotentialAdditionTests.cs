// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PotentialAdditionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Electromagnetism;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    using Xunit;

    public class PotentialAdditionTests
    {
        [Fact]
        public void Potential_Add_Then_ResultShouldBeExpected()
        {
            var lhs = new Potential(5, units => units.Milli.Volts);
            var rhs = new Potential(5000, units => units.Micro.Volts);

            var result = lhs + rhs;

            result.Should().Be(10, "mV", UnitFormat.Default);
        }
    }
}