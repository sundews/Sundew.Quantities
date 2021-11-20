// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiplicationExpressionTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Expressions;

using FluentAssertions;
using Sundew.Base.Visiting;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Expressions.Visitors;
using Sundew.Quantities.Representations.Units;
using Xunit;

public class MultiplicationExpressionTests
{
    [Theory]
    [InlineData(84, 1087340D)]
    [InlineData(0, 0D)]
    [InlineData(-102, 715339.99999999988D)]
    public void Visit_When_ConvertingFromFahrenheitSeconds_Then_ResultShouldBeExpected(
        double value,
        double expected)
    {
        var testee = new MultiplicationExpression(
            UnitDefinitions.Fahrenheit.GetExpression(),
            UnitDefinitions.Hour.GetExpression());
        var result = new Reference<double>();

        testee.Visit(new ValueToBaseVisitor(), value, result);

        result.Value.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
    }
}