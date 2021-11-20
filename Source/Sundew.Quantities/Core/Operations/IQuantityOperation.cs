// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantityOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core.Operations;

/// <summary>
/// Interface for implementing <see cref="IQuantity"/> operations.
/// </summary>
/// <typeparam name="TRhs">The type of the RHS.</typeparam>
public interface IQuantityOperation<in TRhs>
{
    /// <summary>
    /// Executes the specified LHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>A <see cref="IQuantity"/>.</returns>
    IQuantity Execute(IQuantity lhs, TRhs rhs);
}