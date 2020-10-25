// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Periodics
{
    using FluentAssertions;
    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.UnitTests;
    using Xunit;

    public class TimeTests
    {
        [Theory]
        [InlineData(3, 3000000000)]
        [InlineData(0, 0)]
        public void Time_ToUnit_Then_ResultShouldBeExpected(double value, double expected)
        {
            var time = new Time(value, selector => selector.Seconds);

            var result = time.ToUnit(selector => selector.Nano.Seconds);

            result.Should().BeApproximately(expected, "ns", TestHelper.DefaultAssertPrecision);
        }

        [Fact]
        public void Time_Division_ThenTimeInYearsIsRhs_Then_ResultShouldBeExpected()
        {
            const double Expected = 5000000;
            const double Value = 20000000;
            var time = new Time(4, units => units.Years);

            var result = Value / time;

            result.Should().Be(Expected, "1/y", UnitFormat.Default);
        }

        [Fact]
        public void Time_Division_ThenTimeIsRhs_Then_ResultShouldBeExpected()
        {
            const double Expected = 5000000;
            const double Value = 20000000;
            var time = new Time(4, units => units.Seconds);

            var result = Value / time;

            result.Should().Be(Expected, "Hz", UnitFormat.Default);
        }
    }
}