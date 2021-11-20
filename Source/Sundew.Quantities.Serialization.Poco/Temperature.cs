// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Temperature.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Temperature"/> as a serializable type.
/// </summary>
public class Temperature : SerializableQuantity<Quantities.Temperature>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Temperature"/> class.
    /// </summary>
    public Temperature()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Temperature" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Temperature(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Sundew.Quantities.Temperature" />.
    /// </returns>
    public override Quantities.Temperature ToQuantity()
    {
        return new Quantities.Temperature(this.Value, this.GetUnit());
    }
}