// <copyright file="UnitSelectorHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Sundew.Quantities.UnitSelection;

using Sundew.Quantities.Representations.Expressions;

internal static class UnitSelectorHelper
{
    /// <summary>
    /// Creates the expression.
    /// </summary>
    /// <param name="exponent">The exponent.</param>
    /// <param name="prefix">The prefix.</param>
    /// <param name="unit">The unit.</param>
    /// <returns>A <see cref="Expression"/>.</returns>
    public static Expression CreateExpression(ref int exponent, ref Prefix prefix, IUnit unit)
    {
        var actualExponent = exponent;
        var actualPrefix = prefix;
        exponent = 1;
        prefix = null;

        if (actualPrefix != null)
        {
            unit = unit.GetPrefixedUnit(actualPrefix);
        }

        if (actualExponent > 1)
        {
            return new MagnitudeExpression(unit.GetExpression(), new ConstantExpression(actualExponent));
        }

        return unit.GetExpression();
    }
}