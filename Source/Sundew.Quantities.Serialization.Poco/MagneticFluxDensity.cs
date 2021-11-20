﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagneticFluxDensity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

using Sundew.Quantities.Core;

/// <summary>
/// Represents <see cref="Sundew.Quantities.MagneticFluxDensity"/> as a serializable type.
/// </summary>
public class MagneticFluxDensity : SerializableQuantity<Quantities.MagneticFluxDensity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MagneticFluxDensity"/> class.
    /// </summary>
    public MagneticFluxDensity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MagneticFluxDensity" /> class.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    public MagneticFluxDensity(IQuantity quantity)
        : base(quantity)
    {
    }

    /// <summary>
    /// Converts this instances to a quantity.
    /// </summary>
    /// <returns>
    /// A <see cref="Sundew.Quantities.MagneticFluxDensity" />.
    /// </returns>
    public override Quantities.MagneticFluxDensity ToQuantity()
    {
        return new Quantities.MagneticFluxDensity(this.Value, this.GetUnit());
    }
}