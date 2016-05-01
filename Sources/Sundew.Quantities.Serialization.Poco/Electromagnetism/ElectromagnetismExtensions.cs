// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ElectromagnetismExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    /// <summary>
    /// Serialization extension methods for electromagnetism quantities.
    /// </summary>
    public static class ElectromagnetismExtensions
    {
        /// <summary>
        /// Creates the serializable capacitance.
        /// </summary>
        /// <param name="capacitance">The capacitance.</param>
        /// <returns>A new serializable <see cref="Capacitance" />.</returns>
        public static Capacitance ToSerializable(this Quantities.Electromagnetism.Capacitance capacitance)
        {
            return new Capacitance(capacitance);
        }

        /// <summary>
        /// Creates the serializable charge.
        /// </summary>
        /// <param name="charge">The charge.</param>
        /// <returns>A new serializable <see cref="Charge" />.</returns>
        public static Charge ToSerializable(this Quantities.Electromagnetism.Charge charge)
        {
            return new Charge(charge);
        }

        /// <summary>
        /// Creates the serializable conductance.
        /// </summary>
        /// <param name="conductance">The conductance.</param>
        /// <returns>A new serializable <see cref="Conductance" />.</returns>
        public static Conductance ToSerializable(this Quantities.Electromagnetism.Conductance conductance)
        {
            return new Conductance(conductance);
        }

        /// <summary>
        /// Creates the serializable electric current.
        /// </summary>
        /// <param name="electricCurrent">The electric current.</param>
        /// <returns>A new serializable <see cref="ElectricCurrent" />.</returns>
        public static ElectricCurrent ToSerializable(this Quantities.Electromagnetism.ElectricCurrent electricCurrent)
        {
            return new ElectricCurrent(electricCurrent);
        }

        /// <summary>
        /// Creates the serializable inductance.
        /// </summary>
        /// <param name="inductance">The inductance.</param>
        /// <returns>A new serializable <see cref="Inductance" />.</returns>
        public static Inductance ToSerializable(this Quantities.Electromagnetism.Inductance inductance)
        {
            return new Inductance(inductance);
        }

        /// <summary>
        /// Creates the serializable magnetic flux.
        /// </summary>
        /// <param name="magneticFlux">The magnetic flux.</param>
        /// <returns>A new serializable <see cref="MagneticFlux" />.</returns>
        public static MagneticFlux ToSerializable(this Quantities.Electromagnetism.MagneticFlux magneticFlux)
        {
            return new MagneticFlux(magneticFlux);
        }

        /// <summary>
        /// Creates the serializable magnetic flux density.
        /// </summary>
        /// <param name="magneticFluxDensity">The magnetic flux density.</param>
        /// <returns>A new serializable <see cref="MagneticFluxDensity" />.</returns>
        public static MagneticFluxDensity ToSerializable(
            this Quantities.Electromagnetism.MagneticFluxDensity magneticFluxDensity)
        {
            return new MagneticFluxDensity(magneticFluxDensity);
        }

        /// <summary>
        /// Creates the serializable potential.
        /// </summary>
        /// <param name="potential">The potential.</param>
        /// <returns>A new serializable <see cref="Potential" />.</returns>
        public static Potential ToSerializable(this Quantities.Electromagnetism.Potential potential)
        {
            return new Potential(potential);
        }

        /// <summary>
        /// Creates the serializable resistance.
        /// </summary>
        /// <param name="resistance">The resistance.</param>
        /// <returns>A new serializable <see cref="Resistance" />.</returns>
        public static Resistance ToSerializable(this Quantities.Electromagnetism.Resistance resistance)
        {
            return new Resistance(resistance);
        }
    }
}