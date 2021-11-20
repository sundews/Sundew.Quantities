// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Frequency.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Quantities.Frequency"/> as a serializable type.
/// </summary>
public class Frequency : SerializableQuantity<Quantities.Frequency>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Frequency"/> class.
    /// </summary>
    public Frequency()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Frequency"/> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public Frequency(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Quantities.Frequency"/>.
    /// </returns>
    public override Quantities.Frequency ToQuantity()
    {
        return new Quantities.Frequency(this.Value, this.GetUnit());
    }
}