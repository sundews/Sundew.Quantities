// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LuminousFlux.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a luminous flux quantity.
/// </summary>
public partial struct LuminousFlux
{
    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static LuminousIntensity operator /(LuminousFlux lhs, SolidAngle rhs)
    {
        return new LuminousIntensity(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Illuminance operator /(LuminousFlux lhs, Area rhs)
    {
        return new Illuminance(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<LuminousFlux> operator *(LuminousFlux lhs, LuminousFlux rhs)
    {
        return new Squared<LuminousFlux>(new LuminousFlux(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}