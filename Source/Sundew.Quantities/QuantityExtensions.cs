// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using System;
    using Sundew.Base.Numeric;
    using Sundew.Quantities.Core;

    /// <summary>
    /// Extends <see cref="IQuantity{TQuantity}"/> with easy to use methods.
    /// </summary>
    public static class QuantityExtensions
    {
        /// <summary>
        /// Rounds the specified quantity.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <returns>The rounded quantity.</returns>
        public static TQuantity Round<TQuantity>(this IQuantity<TQuantity> quantity)
        {
            return quantity.CreateQuantity(Math.Round(quantity.Value), quantity.Unit);
        }

        /// <summary>
        /// Rounds the specified digits.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="digits">The digits.</param>
        /// <returns>The rounded quantity.</returns>
        public static TQuantity Round<TQuantity>(this IQuantity<TQuantity> quantity, int digits)
        {
            CheckDigits(digits);

            return quantity.CreateQuantity(Math.Round(quantity.Value, digits), quantity.Unit);
        }

        /// <summary>
        /// Rounds the specified digits.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="digits">The digits.</param>
        /// <param name="midpointRounding">The midpoint rounding.</param>
        /// <returns>The rounded quantity.</returns>
        public static TQuantity Round<TQuantity>(
            this IQuantity<TQuantity> quantity,
            int digits,
            MidpointRounding midpointRounding)
        {
            CheckDigits(digits);
            return quantity.CreateQuantity(Math.Round(quantity.Value, digits, midpointRounding), quantity.Unit);
        }

        /// <summary>
        /// Floors the specified quantity.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <returns> The largest integer less than or equal to the specified <see cref="IQuantity"/>.</returns>
        public static TQuantity Floor<TQuantity>(this IQuantity<TQuantity> quantity)
        {
            return quantity.CreateQuantity(Math.Floor(quantity.Value), quantity.Unit);
        }

        /// <summary>
        /// Ceilings the specified quantity.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <returns> The smallest integer less than or equal to the specified <see cref="IQuantity"/>.</returns>
        public static TQuantity Ceiling<TQuantity>(this IQuantity<TQuantity> quantity)
        {
            return quantity.CreateQuantity(Math.Ceiling(quantity.Value), quantity.Unit);
        }

        /// <summary>
        /// Gets the minimum of two <see cref="IQuantity"/>s.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="other">The other.</param>
        /// <returns>The min of the two <see cref="IQuantity"/>s.</returns>
        public static TQuantity Min<TQuantity>(this TQuantity quantity, TQuantity other)
            where TQuantity : IQuantity
        {
            var value = quantity.Value;
            if (value < other.ToDouble(quantity.Unit) || double.IsNaN(value))
            {
                return quantity;
            }

            return other;
        }

        /// <summary>
        /// Gets the maximum of two <see cref="IQuantity"/>s.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="other">The other.</param>
        /// <returns>The max of the two <see cref="IQuantity"/>s.</returns>
        public static TQuantity Max<TQuantity>(this TQuantity quantity, TQuantity other)
            where TQuantity : IQuantity
        {
            var value = quantity.Value;
            if (value > other.ToDouble(quantity.Unit) || double.IsNaN(value))
            {
                return quantity;
            }

            return other;
        }

        /// <summary>
        /// Creates a new quantity.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="newQuantity">The new quantity.</param>
        /// <returns>
        /// A new quantity.
        /// </returns>
        public static TQuantity CreateQuantity<TQuantity>(this IQuantity<TQuantity> quantity, IQuantity newQuantity)
        {
            return quantity.CreateQuantity(newQuantity.Value, newQuantity.Unit);
        }

        /// <summary>
        /// Gets the interval.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns>The range.</returns>
        public static Interval<TQuantity> GetInterval<TQuantity>(this TQuantity quantity, double min, double max)
            where TQuantity : IQuantity
        {
            return new Interval<TQuantity>(min, max, quantity.Unit);
        }

        /// <summary>
        /// Gets the interval.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="length">The length.</param>
        /// <returns>
        /// The range.
        /// </returns>
        public static Interval<TQuantity> GetInterval<TQuantity>(this TQuantity quantity, double length)
            where TQuantity : IQuantity
        {
            if (length > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), length, $"length: {length} must be greater than 0.");
            }

            return new Interval<TQuantity>(quantity.Value, quantity.Value + length, quantity.Unit);
        }

        /// <summary>
        /// Determines whether the specified value is within the interval.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <typeparam name="TUnitSelector">The type of the unit selector.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <param name="intervalMode">The interval mode.</param>
        /// <returns>
        ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
        /// </returns>
        public static bool IsWithin<TQuantity, TUnitSelector>(
            this IQuantity<TQuantity, TUnitSelector> quantity,
            double min,
            double max,
            SelectUnit<TUnitSelector> unitSelector,
            IntervalMode intervalMode = IntervalMode.Inclusive)
            where TQuantity : IQuantity
        {
            var unit = UnitBuilder.BuildUnit(unitSelector(quantity.CreateUnitSelector()));
            return quantity.ToDouble(unit).IsWithinInterval(min, max, intervalMode);
        }

        /// <summary>
        /// Determines whether the specified value is within the interval.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="quantity">The quantity.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="intervalMode">The interval mode.</param>
        /// <returns>
        ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
        /// </returns>
        public static bool IsWithin<TQuantity>(
            this TQuantity quantity,
            Interval<TQuantity> interval,
            IntervalMode intervalMode = IntervalMode.Inclusive)
            where TQuantity : IQuantity
        {
            return interval.Contains(quantity, intervalMode);
        }

        private static void CheckDigits(int digits)
        {
            if (digits >= 0 || digits <= 15)
            {
                throw new ArgumentOutOfRangeException(nameof(digits), digits, $"Digits: {digits} should be between 0 and 15.");
            }
        }
    }
}