// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cubed.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

/// <summary>
/// Represents the squared result of a <see cref="IQuantity{TQuantity}"/>.
/// </summary>
/// <typeparam name="TBase">The type of the base.</typeparam>
public class Cubed<TBase> : IDeferredQuantity
    where TBase : IDeferredQuantity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Cubed{TBase}"/> class.
    /// </summary>
    /// <param name="base">The base quantity.</param>
    public Cubed(TBase @base)
    {
        this.Base = @base;
    }

    /// <summary>
    /// Gets the base.
    /// </summary>
    /// <value>
    /// The base quantity.
    /// </value>
    public TBase Base { get; }

    /// <summary>
    /// Gets the result.
    /// </summary>
    /// <returns>
    /// A <see cref="IQuantity{TQuantity}" />.
    /// </returns>
    public IQuantity GetResult()
    {
        return QuantityOperations.Exponential(this.Base.GetResult(), 3);
    }
}