// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Implementation of the Distance unit.
/// </summary>
public partial struct Distance
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Area operator *(Distance lhs, Distance rhs)
    {
        return new Area(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Volume operator *(Distance lhs, Area rhs)
    {
        return new Volume(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Product<Distance, Squared<Time>> operator *(Distance lhs, Squared<Time> rhs)
    {
        return new Product<Distance, Squared<Time>>(lhs, rhs);
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Acceleration operator /(Distance lhs, Squared<Time> rhs)
    {
        return new Acceleration(QuantityOperations.Divide(lhs, rhs.GetResult()));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Velocity operator /(Distance lhs, Time rhs)
    {
        return new Velocity(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Time operator /(Distance lhs, Velocity rhs)
    {
        return new Time(QuantityOperations.Divide(lhs, rhs));
    }
}