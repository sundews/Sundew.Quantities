// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MassTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Mechanics;

    using Xunit;

    public class MassTests
    {
        [Fact]
        public void Mass_ToUnit_When_ConvertingFromKiloGramToTonne_Then_ResultShouldBe2Tonne()
        {
            var testee = new Mass(2000, x => x.KiloGrams);

            var result = testee.ToUnit(x => x.Tonnes);

            result.Should().Be(2, "t");
        }
    }
}