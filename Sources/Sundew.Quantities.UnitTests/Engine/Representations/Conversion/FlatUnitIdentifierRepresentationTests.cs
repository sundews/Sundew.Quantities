// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatUnitIdentifierRepresentationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Conversion
{
    using FluentAssertions;

    using Sundew.Quantities.UnitTests.Engine.Representations.Flat;

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