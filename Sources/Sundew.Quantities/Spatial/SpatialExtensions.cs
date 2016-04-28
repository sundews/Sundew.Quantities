namespace Sundew.Quantities.Spatial
{
    using System;

    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Extends the structs which implement <see cref="IComparable"/> and <see cref="IFormattable"/> with easy to use methods.
    /// </summary>
    public static class SpatialExtensions
    {
        /// <summary>
        /// Gets the value as meters.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The distance value.</param>
        /// <returns>A <see cref="Distance"/>.</returns>
        public static Distance Meters<TValue>(this TValue value) 
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToDistance(x => x.Meters);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The distance value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Distance"/>.</returns>
        public static Distance ToDistance<TValue>(this TValue value, SelectUnit<DistanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Distance(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as square meters.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The area value.</param>
        /// <returns>A new <see cref="Area"/>.</returns>
        public static Area SquareMeters<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToArea(x => x.Square.Meters);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The area value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Area"/>.</returns>
        public static Area ToArea<TValue>(this TValue value, SelectUnit<DistanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Area(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as cubic meters.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The volume value.</param>
        /// <returns>A new <see cref="Volume"/>.</returns>
        public static Volume CubicMeters<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToVolume(x => x.Meters);
        }

        /// <summary>
        /// Gets the value as liters.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The liter value.</param>
        /// <returns>A new <see cref="Volume"/>.</returns>
        public static Volume Liters<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToVolume(x => x.Liters);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The volume value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Volume"/>.</returns>
        public static Volume ToVolume<TValue>(this TValue value, SelectUnit<VolumeUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Volume(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Radian.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The angle value.</param>
        /// <returns>A new <see cref="Angle"/>.</returns>
        public static Angle Radians<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToAngle(x => x.Radians);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The angle value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="Angle"/>.</returns>
        public static Angle ToAngle<TValue>(this TValue value, SelectUnit<AngleUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Angle(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Steradians.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A new <see cref="SolidAngle"/>.</returns>
        public static SolidAngle Steradians<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToSolidAngle(x => x.Steradians);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The solid angle value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A new <see cref="SolidAngle"/>.</returns>
        public static SolidAngle ToSolidAngle<TValue>(this TValue value, SelectUnit<SolidAngleUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new SolidAngle(Convert.ToDouble(value), unitSelector);
        }
    }
}