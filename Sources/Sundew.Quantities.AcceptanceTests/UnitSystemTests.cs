// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitSystemTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.Parsing;
    using Xunit;

    public class UnitSystemTests
    {
        [Theory]
        [InlineData("C", "A*s")]
        [InlineData("A", "A")]
        public void GetUnit_Then_ResultBaseUnitNotationShouldBeExpected(string unit, string expected)
        {
            var testee = new UnitSystem();
            testee.InitializeUnitSystemWithDefaults();

            var result = testee.GetUnit(unit, ParseSettings.DefaultInvariantCulture).Value;

            result.BaseUnit.GetNotation().Should().Be(expected);
        }
    }
}