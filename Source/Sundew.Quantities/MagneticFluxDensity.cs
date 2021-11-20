// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagneticFluxDensity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a magnetic flux density quantity.
/// </summary>
public partial struct MagneticFluxDensity
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<MagneticFluxDensity> operator *(MagneticFluxDensity lhs, MagneticFluxDensity rhs)
    {
        return new Squared<MagneticFluxDensity>(new MagneticFluxDensity(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}