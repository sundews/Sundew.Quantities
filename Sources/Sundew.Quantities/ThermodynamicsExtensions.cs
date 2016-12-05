// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThermodynamicsExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using System;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.UnitSelection;
    using Sundew.Quantities.UnitSelectors;

    /// <summary>
    /// Extends the structs which implement <see cref="IComparable"/> and <see cref="IFormattable"/> with easy to use methods.
    /// </summary>
    public static class ThermodynamicsExtensions
    {
        /// <summary>
        /// Gets the value as kelvin.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Temperature"/>.</returns>
        public static Temperature Celsius<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToTemperature(x => x.Celsius);
        }

        /// <summary>
        /// Gets the value as kelvin.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Temperature"/>.</returns>
        public static Temperature Kelvin<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToTemperature(x => x.Kelvin);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="Temperature"/>.</returns>
        public static Temperature ToTemperature<TValue>(
            this TValue value,
            SelectUnit<TemperatureUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Temperature(Convert.ToDouble(value), unitSelector);
        }
    }
}