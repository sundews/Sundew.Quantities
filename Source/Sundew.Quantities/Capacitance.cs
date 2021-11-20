// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Capacitance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a capacitance quantity.
/// </summary>
public partial struct Capacitance
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Charge operator *(Capacitance lhs, Potential rhs)
    {
        return new Charge(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Capacitance> operator *(Capacitance lhs, Capacitance rhs)
    {
        return new Squared<Capacitance>(new Capacitance(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}