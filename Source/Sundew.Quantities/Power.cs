// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Power.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a power quantity.
/// </summary>
public partial struct Power
{
    /// <summary>
    /// Divides the lhs with the rhs.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>
    /// The resulting <see cref="Energy"/>.
    /// </returns>
    public static Energy operator *(Power lhs, Time rhs)
    {
        return new Energy(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Divides the lhs with the rhs.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>
    /// The resulting <see cref="Potential"/>.
    /// </returns>
    public static Potential operator /(Power lhs, ElectricCurrent rhs)
    {
        return new Potential(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Power> operator *(Power lhs, Power rhs)
    {
        return new Squared<Power>(new Power(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}