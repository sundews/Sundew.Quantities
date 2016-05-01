// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MechanicsExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics
{
    using System;

    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Mechanics.UnitSelection;

    /// <summary>
    /// Extends the structs which implement <see cref="IComparable"/> and <see cref="IFormattable"/> with easy to use methods.
    /// </summary>
    public static class MechanicsExtensions
    {
        /// <summary>
        /// Gets the value as gram.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The mass value.</param>
        /// <returns>A new <see cref="Mass"/>.</returns>
        public static Mass Grams<TValue>(this TValue value) where TValue : struct, IComparable, IFormattable
        {
            return value.ToMass(x => x.Grams);
        }

        /// <summary>
        /// Gets the value as kilogram.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The mass value.</param>
        /// <returns>A new <see cref="Mass"/>.</returns>
        public static Mass KiloGrams<TValue>(this TValue value) where TValue : struct, IComparable, IFormattable
        {
            return value.ToMass(x => x.KiloGrams);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The mass value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Mass"/>.</returns>
        public static Mass ToMass<TValue>(this TValue value, SelectUnit<MassUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Mass(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Joule.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The energy value.</param>
        /// <returns>A new <see cref="Energy"/>.</returns>
        public static Energy Joules<TValue>(this TValue value) where TValue : struct, IComparable, IFormattable
        {
            return value.ToEnergy(x => x.Joules);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The energy value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Energy"/>.</returns>
        public static Energy ToEnergy<TValue>(this TValue value, SelectUnit<EnergyUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Energy(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Newton.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The force value.</param>
        /// <returns>A new <see cref="Force"/>.</returns>
        public static Force Newtons<TValue>(this TValue value) where TValue : struct, IComparable, IFormattable
        {
            return value.ToForce(x => x.Newtons);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The force value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Force"/>.</returns>
        public static Force ToForce<TValue>(this TValue value, SelectUnit<ForceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Force(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as KiloGram Meter per Second.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A new <see cref="Momentum"/>.</returns>
        public static Momentum KilogramsMeterPerSecond<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToMomentum(x => x.BaseUnit);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The momentum value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Momentum"/>.</returns>
        public static Momentum ToMomentum<TValue>(this TValue value, SelectUnit<MomentumUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Momentum(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Watts.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The power value.</param>
        /// <returns>A new <see cref="Power"/>.</returns>
        public static Power Watts<TValue>(this TValue value) where TValue : struct, IComparable, IFormattable
        {
            return value.ToPower(x => x.Watts);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The power value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Power"/>.</returns>
        public static Power ToPower<TValue>(this TValue value, SelectUnit<PowerUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Power(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Pascal.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The pressure value.</param>
        /// <returns>A new <see cref="Pressure"/>.</returns>
        public static Pressure Pascals<TValue>(this TValue value) where TValue : struct, IComparable, IFormattable
        {
            return value.ToPressure(x => x.Pascals);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The pressure value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Pressure"/>.</returns>
        public static Pressure ToPressure<TValue>(this TValue value, SelectUnit<PressureUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Pressure(Convert.ToDouble(value), unitSelector);
        }
    }
}