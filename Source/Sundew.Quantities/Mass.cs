// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mass.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a mass quantity.
/// </summary>
public partial struct Mass
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Force operator *(Mass lhs, Quotient<Distance, Squared<Time>> rhs)
    {
        return new Force(QuantityOperations.Multiply(lhs, rhs.GetResult()));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Momentum operator *(Mass lhs, Velocity rhs)
    {
        return new Momentum(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Pressure operator /(Mass lhs, Product<Distance, Squared<Time>> rhs)
    {
        return new Pressure(QuantityOperations.Divide(lhs, rhs.GetResult()));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Mass> operator *(Mass lhs, Mass rhs)
    {
        return new Squared<Mass>(new Mass(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}