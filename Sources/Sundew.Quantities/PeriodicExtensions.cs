// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PeriodicExtensions.cs" company="Hukano">
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
    public static class PeriodicExtensions
    {
        /// <summary>
        /// Gets the time as seconds.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Seconds<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Seconds);
        }

        /// <summary>
        /// Gets the time as minutes.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Minutes<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Minutes);
        }

        /// <summary>
        /// Gets the time as hours.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Hours<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Hours);
        }

        /// <summary>
        /// Gets the time as days.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Days<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Days);
        }

        /// <summary>
        /// Gets the time as weeks.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Weeks<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Weeks);
        }

        /// <summary>
        /// Gets the time as months.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Months<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Months);
        }

        /// <summary>
        /// Gets the time as years.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time Years<TValue>(this TValue time)
            where TValue : struct, IComparable, IFormattable
        {
            return time.ToTime(x => x.Years);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="time">The time value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Time" />.</returns>
        public static Time ToTime<TValue>(this TValue time, SelectUnit<TimeUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Time(Convert.ToDouble(time), unitSelector);
        }

        /// <summary>
        /// Gets the value as hertz.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A new <see cref="Frequency"/>.</returns>
        public static Frequency Hertz<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToFrequency(x => x.Hertz);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Frequency"/>.</returns>
        public static Frequency ToFrequency<TValue>(this TValue value, SelectUnit<FrequencyUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Frequency(Convert.ToDouble(value), unitSelector);
        }
    }
}