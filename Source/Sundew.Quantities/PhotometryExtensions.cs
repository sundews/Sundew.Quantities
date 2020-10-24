// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhotometryExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using System;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.UnitSelectors;

    /// <summary>
    /// Extends the structs which implement <see cref="IComparable"/> and <see cref="IFormattable"/> with easy to use methods.
    /// </summary>
    public static class PhotometryExtensions
    {
        /// <summary>
        /// Gets the value as Candela.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="LuminousIntensity"/>.</returns>
        public static LuminousIntensity Candelas<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToLuminousIntensity(x => x.Candelas);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="LuminousIntensity"/>.</returns>
        public static LuminousIntensity ToLuminousIntensity<TValue>(
            this TValue value,
            SelectUnit<LuminousIntensityUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new LuminousIntensity(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Lumen.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="LuminousFlux"/>.</returns>
        public static LuminousFlux Lumens<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToLuminousFlux(x => x.Lumens);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="LuminousFlux"/>.</returns>
        public static LuminousFlux ToLuminousFlux<TValue>(
            this TValue value,
            SelectUnit<LuminousFluxUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new LuminousFlux(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Lux.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Illuminance"/>.</returns>
        public static Illuminance Lux<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToIlluminance(x => x.Lux);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="Illuminance"/>.</returns>
        public static Illuminance ToIlluminance<TValue>(
            this TValue value,
            SelectUnit<IlluminanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Illuminance(Convert.ToDouble(value), unitSelector);
        }
    }
}