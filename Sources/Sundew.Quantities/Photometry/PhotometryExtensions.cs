namespace Sundew.Quantities.Photometry
{
    using System;

    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Photometry.UnitSelection;

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
        public static LuminousIntensity ToLuminousIntensity<TValue>(this TValue value, SelectUnit<LuminousIntensityUnitSelector> unitSelector)
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
        public static LuminousFlux ToLuminousFlux<TValue>(this TValue value, SelectUnit<LuminousFluxUnitSelector> unitSelector)
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
        public static Illuminance ToIlluminance<TValue>(this TValue value, SelectUnit<IlluminanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Illuminance(Convert.ToDouble(value), unitSelector);
        }

        /*
        /// <summary>
        /// Gets the value as Ampere.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="ElectricCurrent"/>.</returns>
        public static ElectricCurrent Ampere<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToElectricCurrent(x => x.Ampere);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="ElectricCurrent"/>.</returns>
        public static ElectricCurrent ToElectricCurrent<TValue>(this TValue value, SelectUnit<ElectricCurrentUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new ElectricCurrent(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Henry.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Inductance"/>.</returns>
        public static Inductance Henry<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToInductance(x => x.Henry);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="Inductance"/>.</returns>
        public static Inductance ToInductance<TValue>(this TValue value, SelectUnit<InductanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Inductance(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Weber.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="MagneticFlux"/>.</returns>
        public static MagneticFlux Weber<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToMagneticFlux(x => x.Weber);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="MagneticFlux"/>.</returns>
        public static MagneticFlux ToMagneticFlux<TValue>(this TValue value, SelectUnit<MagneticFluxUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new MagneticFlux(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Tesla.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="MagneticFluxDensity"/>.</returns>
        public static MagneticFluxDensity Tesla<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToMagneticFluxDensity(x => x.Tesla);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="MagneticFluxDensity"/>.</returns>
        public static MagneticFluxDensity ToMagneticFluxDensity<TValue>(this TValue value, SelectUnit<MagneticFluxDensityUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new MagneticFluxDensity(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Volt.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Potential"/>.</returns>
        public static Potential Volt<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToPotential(x => x.Volt);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="Potential"/>.</returns>
        public static Potential ToPotential<TValue>(this TValue value, SelectUnit<PotentialUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Potential(Convert.ToDouble(value), unitSelector);
        }

        /// <summary>
        /// Gets the value as Ohm.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Resistance"/>.</returns>
        public static Resistance Ohm<TValue>(this TValue value)
            where TValue : struct, IComparable, IFormattable
        {
            return value.ToResistance(x => x.Ohm);
        }

        /// <summary>
        /// Gets the value as the specified unit.
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>A <see cref="Resistance"/>.</returns>
        public static Resistance ToResistance<TValue>(this TValue value, SelectUnit<ResistanceUnitSelector> unitSelector)
            where TValue : struct, IComparable, IFormattable
        {
            return new Resistance(Convert.ToDouble(value), unitSelector);
        }*/
    }
}