// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PeriodicsExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco;

/// <summary>
/// Serialization extension methods for periodic quantities.
/// </summary>
public static class PeriodicsExtensions
{
    /// <summary>
    /// Creates the serializable frequency.
    /// </summary>
    /// <param name="frequency">The frequency.</param>
    /// <returns>A new serializable <see cref="Frequency" />.</returns>
    public static Frequency ToSerializable(this Quantities.Frequency frequency)
    {
        return new Frequency(frequency);
    }

    /// <summary>
    /// Creates the serializable time.
    /// </summary>
    /// <param name="time">The time.</param>
    /// <returns>A new serializable <see cref="Time" />.</returns>
    public static Time ToSerializable(this Quantities.Time time)
    {
        return new Time(time);
    }
}