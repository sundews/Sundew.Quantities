// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pressure.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Pressure"/> as a serializable type.
/// </summary>
public class Pressure : SerializableQuantity<Quantities.Pressure>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Pressure"/> class.
    /// </summary>
    public Pressure()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Pressure"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Pressure(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Pressure"/>.</returns>
    public override Quantities.Pressure ToQuantity()
    {
        return new Quantities.Pressure(this.Value, this.GetUnit());
    }
}