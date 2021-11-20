// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpacetimeExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using System;
using Sundew.Quantities.Core;
using Sundew.Quantities.UnitSelectors;

/// <summary>
/// Extends the structs which implement <see cref="IComparable"/> and <see cref="IFormattable"/> with easy to use methods.
/// </summary>
public static class SpacetimeExtensions
{
    /// <summary>
    /// Gets the value as meters per seconds.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value.</param>
    /// <returns>A <see cref="Velocity"/>.</returns>
    public static Velocity MetersPerSecond<TValue>(this TValue value)
        where TValue : struct, IComparable, IFormattable
    {
        return value.ToVelocity(x => x.BaseUnit);
    }

    /// <summary>
    /// Gets the value as the specified unit.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="unitSelector">The unit selector.</param>
    /// <returns>A <see cref="Velocity"/>.</returns>
    public static Velocity ToVelocity<TValue>(this TValue value, SelectUnit<VelocityUnitSelector> unitSelector)
        where TValue : struct, IComparable, IFormattable
    {
        return new Velocity(Convert.ToDouble(value), unitSelector);
    }

    /// <summary>
    /// Gets the value as meters per seconds squared.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value.</param>
    /// <returns>A <see cref="Acceleration"/>.</returns>
    public static Acceleration MetersPerSecondSquared<TValue>(this TValue value)
        where TValue : struct, IComparable, IFormattable
    {
        return value.ToAcceleration(x => x.BaseUnit);
    }

    /// <summary>
    /// Gets the value as the specified unit.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="unitSelector">The unit selector.</param>
    /// <returns>A <see cref="Acceleration"/>.</returns>
    public static Acceleration ToAcceleration<TValue>(
        this TValue value,
        SelectUnit<AccelerationUnitSelector> unitSelector)
        where TValue : struct, IComparable, IFormattable
    {
        return new Acceleration(Convert.ToDouble(value), unitSelector);
    }
}