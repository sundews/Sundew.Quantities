// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityExtensionsTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;

    using Sundew.Base.Numeric;
    using Sundew.Quantities.Spatial;

    using Xunit;

    public class QuantityExtensionsTests
    {
        [Theory]
        [InlineData(2.999999, false)]
        [InlineData(3, true)]
        [InlineData(44, true)]
        [InlineData(44.0000001, false)]
        public void IsWithin_Then_ResultShouldBeExpectedResult(double quantity, bool expectedResult)
        {
            var testee = quantity.CubicMeters();

            var result = testee.IsWithin(3, 44, x => x.Cubic.Meters);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(2.999999, false)]
        [InlineData(3, false)]
        [InlineData(3.000001, true)]
        [InlineData(43.999999, true)]
        [InlineData(44, false)]
        [InlineData(44.0000001, false)]
        public void IsWithin_When_IntervalModeIsExclusive_Then_ResultShouldBeExpectedResult(
            double quantity,
            bool expectedResult)
        {
            var testee = quantity.CubicMeters();
            var interval = testee.GetInterval(3, 44);

            var result = testee.IsWithin(interval, IntervalMode.Exclusive);

            result.Should().Be(expectedResult);
        }
    }
}