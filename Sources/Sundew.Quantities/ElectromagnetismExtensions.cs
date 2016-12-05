// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectromagnetismExtensions.cs" company="Hukano">
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
    public static class ElectromagnetismExtensions
    {
        /// <summary>
        /// Gets the value as Farad.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The capacitance value.</param>
        /// <returns>A new <see cref="Capacitance"/>.</returns>
        public static Capacitance Farads<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToCapacitance(x => x.Farads);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The capacitance value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Capacitance"/>.</returns>
        public static Capacitance ToCapacitance<TValue>(
            this TValue value,
            SelectUnit<CapacitanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Capacitance(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Coulomb.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The charge value.</param>
        /// <returns>A new <see cref="Charge"/>.</returns>
        public static Charge Coulombs<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToCharge(x => x.Coulombs);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The charge value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Charge"/>.</returns>
        public static Charge ToCharge<TValue>(this TValue value, SelectUnit<ChargeUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Charge(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Siemens.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The conductance value.</param>
        /// <returns>A new <see cref="Conductance"/>.</returns>
        public static Conductance Siemens<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToConductance(x => x.Siemens);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The conductance value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Conductance"/>.</returns>
        public static Conductance ToConductance<TValue>(
            this TValue value,
            SelectUnit<ConductanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Conductance(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as ampere.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The electric current value.</param>
        /// <returns>A new <see cref="ElectricCurrent"/>.</returns>
        public static ElectricCurrent Amperes<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToElectricCurrent(x => x.Amperes);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The electric current value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="ElectricCurrent"/>.</returns>
        public static ElectricCurrent ToElectricCurrent<TValue>(
            this TValue value,
            SelectUnit<ElectricCurrentUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new ElectricCurrent(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Henry.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The inductance value.</param>
        /// <returns>A new <see cref="Inductance"/>.</returns>
        public static Inductance Henry<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToInductance(x => x.Henry);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The inductance value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Inductance"/>.</returns>
        public static Inductance ToInductance<TValue>(
            this TValue value,
            SelectUnit<InductanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Inductance(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Weber.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The magnetic flux value.</param>
        /// <returns>A new <see cref="MagneticFlux"/>.</returns>
        public static MagneticFlux Webers<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToMagneticFlux(x => x.Webers);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The magnetic flux value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="MagneticFlux"/>.</returns>
        public static MagneticFlux ToMagneticFlux<TValue>(
            this TValue value,
            SelectUnit<MagneticFluxUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new MagneticFlux(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Tesla.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The magnetic flux density value.</param>
        /// <returns>A new <see cref="MagneticFluxDensity"/>.</returns>
        public static MagneticFluxDensity Teslas<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToMagneticFluxDensity(x => x.Teslas);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The magnetic flux density value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="MagneticFluxDensity"/>.</returns>
        public static MagneticFluxDensity ToMagneticFluxDensity<TValue>(
            this TValue value,
            SelectUnit<MagneticFluxDensityUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new MagneticFluxDensity(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Volt.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The potential value.</param>
        /// <returns>A new <see cref="Potential"/>.</returns>
        public static Potential Volts<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToPotential(x => x.Volts);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The potential value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Potential"/>.</returns>
        public static Potential ToPotential<TValue>(this TValue value, SelectUnit<PotentialUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Potential(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Ohm.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The resistance value.</param>
        /// <returns>A new <see cref="Resistance"/>.</returns>
        public static Resistance Ohms<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToResistance(x => x.Ohms);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The resistance value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Resistance"/>.</returns>
        public static Resistance ToResistance<TValue>(
            this TValue value,
            SelectUnit<ResistanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Resistance(Convert.ToDouble(value), unitSelector);
        }
    }
}