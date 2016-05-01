// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="RadianUnitTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Units
{
    using System;
    using System.Globalization;

    using FluentAssertions;

    using Sundew.Quantities.Engine.Units;

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