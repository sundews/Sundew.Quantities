// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpatialExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

/// <summary>
/// Serialization extension methods for spatial quantities.
/// </summary>
public static class SpatialExtensions
{
    /// <summary>
    /// Creates the serializable angle.
    /// </summary>
    /// <param name="angle">The angle.</param>
    /// <returns>A new serializable <see cref="Angle" />.</returns>
    public static Angle ToSerializable(this Quantities.Angle angle)
    {
        return new Angle(angle);
    }

    /// <summary>
    /// Creates the serializable area.
    /// </summary>
    /// <param name="area">The area quantity.</param>
    /// <returns>A new serializable <see cref="Area" />.</returns>
    public static Area ToSerializable(this Quantities.Area area)
    {
        return new Area(area);
    }

    /// <summary>
    /// Creates the serializable distance.
    /// </summary>
    /// <param name="distance">The distance quantity.</param>
    /// <returns>A new serializable <see cref="Distance"/>.</returns>
    public static Distance ToSerializable(this Quantities.Distance distance)
    {
        return new Distance(distance);
    }

    /// <summary>
    /// Creates the serializable solid angle.
    /// </summary>
    /// <param name="solidAngle">The solid angle.</param>
    /// <returns>A new serializable <see cref="SolidAngle" />.</returns>
    public static SolidAngle ToSerializable(this Quantities.SolidAngle solidAngle)
    {
        return new SolidAngle(solidAngle);
    }

    /// <summary>
    /// Creates the serializable volume.
    /// </summary>
    /// <param name="volume">The volume.</param>
    /// <returns>A new serializable <see cref="Volume" />.</returns>
    public static Volume ToSerializable(this Quantities.Volume volume)
    {
        return new Volume(volume);
    }
}