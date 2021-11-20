﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quantity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Quantity"/> serializable type.
/// </summary>
public class Quantity : SerializableQuantity<Core.Quantity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Quantity"/> class.
    /// </summary>
    public Quantity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Quantity"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Quantity(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Quantity" />.
    /// </returns>
    public override Core.Quantity ToQuantity()
    {
        return new Core.Quantity(this.Value, this.GetUnit());
    }
}