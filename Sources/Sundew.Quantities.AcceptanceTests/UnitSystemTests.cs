// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitSystemTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Parsing;

namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;
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