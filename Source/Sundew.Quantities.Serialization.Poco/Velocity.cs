// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Velocity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Velocity"/> as a serializable type.
/// </summary>
public sealed class Velocity : SerializableQuantity<Quantities.Velocity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Velocity"/> class.
    /// </summary>
    public Velocity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Velocity"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Velocity(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>A <see cref="Sundew.Quantities.Velocity"/>.</returns>
    public override Quantities.Velocity ToQuantity()
    {
        return new Quantities.Velocity(this.Value, this.GetUnit());
    }
}