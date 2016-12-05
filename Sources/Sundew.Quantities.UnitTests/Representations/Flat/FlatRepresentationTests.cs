// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatRepresentationTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Representations.Flat
{
    using FluentAssertions;
    using Xunit;

    public class FlatRepresentationTests
    {
        [Theory]
        [InlineData("kg", 2, "kg", 2, true)]
        [InlineData("kg", 2, "kg", 1, false)]
        [InlineData("kg", 2, "g", 2, false)]
        public void Equals_Then_ResultShouldBeExpected(
            string unit,
            double unitExponent,
            string other,
            double otherExponent,
            bool expected)
        {
            var testee = FlatUnit.CreateFlatRepresentation(new FlatUnit(unit, unitExponent));
            var rhs = FlatUnit.CreateFlatRepresentation(new FlatUnit(other, otherExponent));

            var result = testee.Equals(rhs);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("kg", 2, "kg", 2, true)]
        [InlineData("kg", 2, "kg", 1, false)]
        [InlineData("kg", 2, "g", 2, false)]
        public void GetHashcode_Then_ResultShouldBeSameAsOtherResult(
            string unit,
            double unitExponent,
            string other,
            double otherExponent,
            bool expected)
        {
            var testee = FlatUnit.CreateFlatRepresentation(new FlatUnit(unit, unitExponent));
            var rhs = FlatUnit.CreateFlatRepresentation(new FlatUnit(other, otherExponent));

            var result = testee.GetHashCode();
            var otherResult = rhs.GetHashCode();

            result.Equals(otherResult).Should().Be(expected);
        }

        [Fact]
        public void ToString_Then_ResultShouldBeExpectedNotation()
        {
            const string ExpectedNotation = "m¹*h⁻¹*s⁻¹";
            var testee = FlatUnit.CreateFlatRepresentation(
                new FlatUnit("m"),
                new FlatUnit("h", -1),
                new FlatUnit("s", -1));

            var result = testee.ToString();

            result.Should().Be(ExpectedNotation);
        }
    }
}