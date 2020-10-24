// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForceFormattingTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;
    using Sundew.Quantities.Core;
    using Xunit;

    public class ForceFormattingTests
    {
        [Theory]
        [InlineData(UnitFormat.Default, "1 N")]
        [InlineData(UnitFormat.SurroundInBrackets, "1 [N]")]
        public void Force_ToString_When_UnitModeIsSpecified_Then_ResultShouldBeExpected(
            UnitFormat unitFormat,
            string expected)
        {
            var testee = new Force(1, x => x.Newtons);

            var result = testee.ToString(unitFormat);

            result.Should().Be(expected);
        }
    }
}