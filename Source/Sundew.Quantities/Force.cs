// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Force.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a force quantity.
/// </summary>
public partial struct Force
{
    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Energy operator *(Force lhs, Distance rhs)
    {
        return new Energy(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Momentum operator *(Force lhs, Time rhs)
    {
        return new Momentum(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Pressure operator /(Force lhs, Area rhs)
    {
        return new Pressure(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Force> operator *(Force lhs, Force rhs)
    {
        return new Squared<Force>(new Force(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}