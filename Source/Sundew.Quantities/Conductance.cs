// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Conductance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a conductance quantity.
/// </summary>
public partial struct Conductance
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Conductance> operator *(Conductance lhs, Conductance rhs)
    {
        return new Squared<Conductance>(new Conductance(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}