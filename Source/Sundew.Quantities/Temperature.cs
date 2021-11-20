// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Temperature.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a temperature quantity.
/// </summary>
public partial struct Temperature
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Temperature> operator *(Temperature lhs, Temperature rhs)
    {
        return new Squared<Temperature>(new Temperature(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}