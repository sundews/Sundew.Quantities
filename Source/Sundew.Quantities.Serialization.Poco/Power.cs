// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Power.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Power"/> as a serializable type.
/// </summary>
public class Power : SerializableQuantity<Quantities.Power>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Power"/> class.
    /// </summary>
    public Power()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Power"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Power(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Power"/>.</returns>
    public override Quantities.Power ToQuantity()
    {
        return new Quantities.Power(this.Value, this.GetUnit());
    }
}