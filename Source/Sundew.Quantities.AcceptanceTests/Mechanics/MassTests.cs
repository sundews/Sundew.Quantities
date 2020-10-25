// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

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