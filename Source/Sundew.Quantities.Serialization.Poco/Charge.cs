// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Charge.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Charge"/> as a serializable type.
/// </summary>
public class Charge : SerializableQuantity<Quantities.Charge>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Charge"/> class.
    /// </summary>
    public Charge()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Charge" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Charge(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts the serializable charge to a quantity charge.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Charge"/>.</returns>
    public override Quantities.Charge ToQuantity()
    {
        return new Quantities.Charge(this.Value, this.GetUnit());
    }
}