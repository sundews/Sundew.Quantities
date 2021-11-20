// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHaveLhsAndRhs.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Interface for <see cref="Expression"/> with a lhs and a rhs.
/// </summary>
/// <typeparam name="TObject">The type of the object.</typeparam>
public interface IHaveLhsAndRhs<out TObject>
{
    /// <summary>
    /// Gets the LHS.
    /// </summary>
    /// <value>
    /// The LHS object.
    /// </value>
    TObject Lhs { get; }

    /// <summary>
    /// Gets the RHS.
    /// </summary>
    /// <value>
    /// The RHS object.
    /// </value>
    TObject Rhs { get; }
}