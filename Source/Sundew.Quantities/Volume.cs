// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volume.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Quantities.Core;

/// <summary>
/// Represents a volume quantity.
/// </summary>
public partial struct Volume
{
    /// <summary>
    /// Performs an implicit conversion from <see cref="Cubed{TBase}"/> to <see cref="Volume"/>.
    /// </summary>
    /// <param name="volume">The volume.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator Volume(Cubed<Distance> volume)
    {
        return new Volume(volume.GetResult());
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The product of the specified LHS and RHS.</returns>
    public static Energy operator *(Volume lhs, Pressure rhs)
    {
        return new Energy(QuantityOperations.Multiply(lhs, rhs));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Distance operator /(Volume lhs, Area rhs)
    {
        return new Distance(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Divides the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>The quotient of the specified LHS and RHS.</returns>
    public static Area operator /(Volume lhs, Distance rhs)
    {
        return new Area(QuantityOperations.Divide(lhs, rhs));
    }

    /// <summary>
    /// Multiplies the specified LHS and RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static Squared<Volume> operator *(Volume lhs, Volume rhs)
    {
        return new Squared<Volume>(new Volume(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
    }
}