// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Potential.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Potential"/> as a serializable type.
/// </summary>
public class Potential : SerializableQuantity<Quantities.Potential>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Potential"/> class.
    /// </summary>
    public Potential()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Potential" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Potential(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts the serializable potential to a quantity potential.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Charge"/>.</returns>
    public override Quantities.Potential ToQuantity()
    {
        return new Quantities.Potential(this.Value, this.GetUnit());
    }
}