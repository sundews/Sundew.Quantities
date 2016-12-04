// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MechanicsExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Serialization extension methods for mechanics quantities.
    /// </summary>
    public static class MechanicsExtensions
    {
        /// <summary>
        /// Creates the serializable energy.
        /// </summary>
        /// <param name="energy">The energy.</param>
        /// <returns>A new serializable <see cref="Energy" />.</returns>
        public static Energy ToSerializable(this Quantities.Energy energy)
        {
            return new Energy(energy);
        }

        /// <summary>
        /// Creates the serializable force.
        /// </summary>
        /// <param name="force">The force.</param>
        /// <returns>A new serializable <see cref="Force" />.</returns>
        public static Force ToSerializable(this Quantities.Force force)
        {
            return new Force(force);
        }

        /// <summary>
        /// Creates the serializable mass.
        /// </summary>
        /// <param name="mass">The mass quantity.</param>
        /// <returns>A new serializable <see cref="Mass"/>.</returns>
        public static Mass ToSerializable(this Quantities.Mass mass)
        {
            return new Mass(mass);
        }

        /// <summary>
        /// Creates the serializable momentum.
        /// </summary>
        /// <param name="momentum">The momentum.</param>
        /// <returns>A new serializable <see cref="Momentum" />.</returns>
        public static Momentum ToSerializable(this Quantities.Momentum momentum)
        {
            return new Momentum(momentum);
        }

        /// <summary>
        /// Creates the serializable power.
        /// </summary>
        /// <param name="power">The power.</param>
        /// <returns>A new serializable <see cref="Power" />.</returns>
        public static Power ToSerializable(this Quantities.Power power)
        {
            return new Power(power);
        }

        /// <summary>
        /// Creates the serializable pressure.
        /// </summary>
        /// <param name="pressure">The pressure.</param>
        /// <returns>A new serializable <see cref="Pressure" />.</returns>
        public static Pressure ToSerializable(this Quantities.Pressure pressure)
        {
            return new Pressure(pressure);
        }
    }
}