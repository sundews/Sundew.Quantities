// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Conductance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.ElectricCurrent"/> as a serializable type.
/// </summary>
public class Conductance : SerializableQuantity<Quantities.Conductance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Conductance"/> class.
    /// </summary>
    public Conductance()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Conductance" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Conductance(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts the serializable electric current to a <see cref="Sundew.Quantities.Conductance"/>.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Conductance"/>.</returns>
    public override Quantities.Conductance ToQuantity()
    {
        return new Quantities.Conductance(this.Value, this.GetUnit());
    }
}