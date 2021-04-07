// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityExtensionsTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;

    using Sundew.Base.Primitives.Numeric;

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