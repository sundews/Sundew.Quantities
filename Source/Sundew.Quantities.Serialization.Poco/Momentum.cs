// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Momentum.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Momentum"/> as a serializable type.
/// </summary>
public class Momentum : SerializableQuantity<Quantities.Momentum>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Momentum"/> class.
    /// </summary>
    public Momentum()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Momentum"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Momentum(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Momentum"/>.</returns>
    public override Quantities.Momentum ToQuantity()
    {
        return new Quantities.Momentum(this.Value, this.GetUnit());
    }
}