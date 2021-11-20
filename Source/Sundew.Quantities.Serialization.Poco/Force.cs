// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Force.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.Force"/> as a serializable type.
/// </summary>
public class Force : SerializableQuantity<Quantities.Force>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Force"/> class.
    /// </summary>
    public Force()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Force" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Force(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>A new <see cref="Force"/>.</returns>
    public override Quantities.Force ToQuantity()
    {
        return new Quantities.Force(this.Value, this.GetUnit());
    }
}