// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDeferredQuantity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Core;

/// <summary>
/// Interface for implementing compositions of quantities.
/// </summary>
public interface IDeferredQuantity
{
    /// <summary>
    /// Gets the result.
    /// </summary>
    /// <returns>An <see cref="IQuantity"/>.</returns>
    IQuantity GetResult();
}