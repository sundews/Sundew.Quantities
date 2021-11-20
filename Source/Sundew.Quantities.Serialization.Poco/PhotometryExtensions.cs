﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhotometryExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

/// <summary>
/// Serialization extension methods for photometry quantities.
/// </summary>
public static class PhotometryExtensions
{
    /// <summary>
    /// Creates the serializable illuminance.
    /// </summary>
    /// <param name="illuminance">The illuminance.</param>
    /// <returns>A new serializable <see cref="Illuminance" />.</returns>
    public static Illuminance ToSerializable(this Quantities.Illuminance illuminance)
    {
        return new Illuminance(illuminance);
    }

    /// <summary>
    /// Creates the serializable luminous flux.
    /// </summary>
    /// <param name="luminousFlux">The luminous flux.</param>
    /// <returns>A new serializable <see cref="LuminousFlux" />.</returns>
    public static LuminousFlux ToSerializable(this Quantities.LuminousFlux luminousFlux)
    {
        return new LuminousFlux(luminousFlux);
    }

    /// <summary>
    /// Creates the serializable luminous intensity.
    /// </summary>
    /// <param name="luminousIntensity">The luminous intensity.</param>
    /// <returns>A new serializable <see cref="LuminousIntensity" />.</returns>
    public static LuminousIntensity ToSerializable(this Quantities.LuminousIntensity luminousIntensity)
    {
        return new LuminousIntensity(luminousIntensity);
    }
}