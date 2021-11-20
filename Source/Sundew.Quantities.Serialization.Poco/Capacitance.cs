﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Capacitance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Capacitance"/> as a serializable type.
/// </summary>
public class Capacitance : SerializableQuantity<Quantities.Capacitance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Capacitance"/> class.
    /// </summary>
    public Capacitance()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Capacitance" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Capacitance(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Sundew.Quantities.Capacitance" />.
    /// </returns>
    public override Quantities.Capacitance ToQuantity()
    {
        return new Quantities.Capacitance(this.Value, this.GetUnit());
    }
}