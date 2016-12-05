// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DistanceComparisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core.Exceptions;

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using System;

    using FluentAssertions;
    using Xunit;

    public class DistanceComparisionTests
    {
        [Theory]
        [InlineData(4, 6, -1)]
        [InlineData(6, 6, 0)]
        [InlineData(6, 2, 1)]
        public void Distance_CompareTo_Then_ResultShouldBeExpected(double lhs, double rhs, int expected)
        {
            var testee1 = new Distance(lhs, x => x.Centi.Meters);
            var testee2 = new Distance(rhs, x => x.Centi.Meters);

            var result = testee1.CompareTo(testee2);

            result.Should().Be(expected);
        }

        [Fact]
        public void Distance_CompareTo_Then_ResultShouldBeAsExpected()
        {
            var testee1 = 1000.Meters();
            var testee2 = new Distance(1, x => x.Kilo.Meters);

            var result = testee1.CompareTo(testee2);

            result.Should().Be(0);
        }

        [Fact]
        public void Distance_CompareTo_When_RhsIsNotADistance_Then_UnitMismatchExceptionShouldBeThrown()
        {
            var lhs = 43.Meters();
            var rhs = 23D.Seconds();

            Action act = () => lhs.CompareTo(rhs);

            act.ShouldThrow<UnitMismatchException>().Which.OperationType.Should().Be(OperationType.Compare);
        }
    }
}