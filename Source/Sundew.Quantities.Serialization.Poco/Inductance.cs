﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inductance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Inductance"/> as a serializable type.
/// </summary>
public class Inductance : SerializableQuantity<Quantities.Inductance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Inductance"/> class.
    /// </summary>
    public Inductance()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Inductance" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Inductance(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Sundew.Quantities.Inductance" />.
    /// </returns>
    public override Quantities.Inductance ToQuantity()
    {
        return new Quantities.Inductance(this.Value, this.GetUnit());
    }
}