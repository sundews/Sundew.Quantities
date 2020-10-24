// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RadianUnitTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Units
{
    using System;
    using System.Globalization;
    using FluentAssertions;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class RadianUnitTests
    {
        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1π")]
        [InlineData(2, "2π")]
        [InlineData(0.5, "0.5π")]
        public void FormatValue_Then_ResultShouldBeExpected(double radians, string expected)
        {
            var radianUnit = new RadianUnit("rad");

            var result = radianUnit.FormatValue(radians * Math.PI, null, CultureInfo.InvariantCulture);

            result.Should().Be(expected);
        }
    }
}