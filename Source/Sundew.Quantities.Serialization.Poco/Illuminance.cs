// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Illuminance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Illuminance"/> as a serializable type.
/// </summary>
public class Illuminance : SerializableQuantity<Quantities.Illuminance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Illuminance"/> class.
    /// </summary>
    public Illuminance()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Illuminance"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Illuminance(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Sundew.Quantities.Illuminance"/>.
    /// </returns>
    public override Quantities.Illuminance ToQuantity()
    {
        return new Quantities.Illuminance(this.Value, this.GetUnit());
    }
}