// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Formatters.MathML;

using System.Xml.Linq;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Extends the <see cref="IUnit"/> interface with math ml functionality.
/// </summary>
public static class UnitExtensions
{
    /// <summary>
    /// To the math ml as a string.
    /// </summary>
    /// <param name="unit">The unit.</param>
    /// <param name="multiplicationSign">The multiplication sign.</param>
    /// <returns>The resulting MathML string.</returns>
    public static string ToMathMLString(
        this IUnit unit,
        MultiplicationSign multiplicationSign = MultiplicationSign.Invisible)
    {
        return unit.ToMathML(multiplicationSign).ToString();
    }

    /// <summary>
    /// Gets the math ml.
    /// </summary>
    /// <param name="unit">The unit.</param>
    /// <param name="multiplicationSign">The multiplication sign.</param>
    /// <returns>
    /// The root <see cref="XElement" /> of the MathML.
    /// </returns>
    public static XElement ToMathML(
        this IUnit unit,
        MultiplicationSign multiplicationSign = MultiplicationSign.Invisible)
    {
        return ExpressionToMathMLVisitor.DefaultMathMLVisitor.Visit(unit.GetExpression(), multiplicationSign);
    }
}