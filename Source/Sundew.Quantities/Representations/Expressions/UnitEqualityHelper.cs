// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitEqualityHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Helper class for <see cref="IUnit" />.
/// </summary>
public static class UnitEqualityHelper
{
    /// <summary>
    /// Checks if the LHS and the RHS base units are equal.
    /// </summary>
    /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
    /// <param name="rhs">The RHS <see cref="IUnit"/>.</param>
    /// <returns>
    ///     <c>true</c>, if the base unit are the equal.
    /// </returns>
    public static bool AreBaseUnitsEqual(IUnit lhs, IUnit rhs)
    {
        return lhs.BaseUnit.Equals(rhs.BaseUnit);
    }

    /// <summary>
    /// Checks if the LHS and the RHS are equal.
    /// </summary>
    /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
    /// <param name="rhs">The RHS <see cref="object"/>.</param>
    /// <returns>
    /// A value indication whether the lhs and the rhs are equal.
    /// </returns>
    public static bool AreUnitsEqual(IUnit lhs, object rhs)
    {
        return AreUnitsEqual(lhs, rhs as IUnit);
    }

    /// <summary>
    /// Checks if the lhs and the rhs are equal.
    /// </summary>
    /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
    /// <param name="rhs">The RHS <see cref="IUnit"/>.</param>
    /// <returns>
    /// A value indication whether the lhs and the rhs are equal.
    /// </returns>
    public static bool AreUnitsEqual(IUnit lhs, IUnit rhs)
    {
        if (rhs == null || lhs == null)
        {
            return false;
        }

        if (!lhs.PrefixFactor.Equals(rhs.PrefixFactor))
        {
            return false;
        }

        if (!IsNotationEqual(lhs, rhs))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <param name="unit">The quantity unit.</param>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    public static int GetHashCode(IUnit unit)
    {
        return unit.PrefixFactor.GetHashCode() ^ unit.Notation.GetHashCode();
    }

    internal static bool IsNotationEqual(IUnit lhs, IUnit rhs)
    {
        return lhs.GetNotationWithoutPrefix().Equals(rhs.GetNotationWithoutPrefix());
    }
}