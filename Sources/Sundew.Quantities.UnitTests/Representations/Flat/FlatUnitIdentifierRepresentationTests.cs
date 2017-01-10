// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatUnitIdentifierRepresentationTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Flat
{
    using FluentAssertions;
    using Xunit;

    public class FlatUnitIdentifierRepresentationTests
    {
        [Fact]
        public void ToResultExpression_Then_ResultShouldBeExpected()
        {
            var testee = new FlatUnit("s").GetFlatIdentifierRepresentation();

            var result = testee.ToResultingExpression();

            result.ToString().Should().Be("s");
        }

        [Fact]
        public void ToResultExpression_When_SingleUnitRaisedInMinusOne_Then_ResultShouldBeSingleUnit()
        {
            var testee = new FlatUnit("s", -1).GetFlatIdentifierRepresentation();

            var result = testee.ToResultingExpression();

            result.ToString().Should().Be("s");
        }

        [Fact]
        public void ToResultExpression_When_UnitHasExponent_Then_ResultShouldBeExpected()
        {
            var testee = new FlatUnit("s", exponent: 2).GetFlatIdentifierRepresentation();

            var result = testee.ToResultingExpression();

            result.ToString().Should().Be("s²");
        }
    }
}