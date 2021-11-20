// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitBuilder.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Enables building derived units by implementing multiplication and division operators.
/// </summary>
internal static class UnitBuilder
{
    /// <summary>
    /// Builds the unit.
    /// </summary>
    /// <param name="unit">The quantity unit.</param>
    /// <returns>A new <see cref="IUnit"/>.</returns>
    internal static IUnit BuildUnit(IUnit unit)
    {
        return BuildUnit(unit.GetExpression());
    }

    /// <summary>
    /// Builds the unit.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <returns>A new <see cref="IUnit"/>.</returns>
    internal static IUnit BuildUnit(Expression expression)
    {
        return UnitSystem.UnitFactory.Create(expression);
    }
}