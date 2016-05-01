// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ThermodynamicsExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Thermodynamics
{
    /// <summary>
    /// Serialization extension methods for thermodynamic quantities.
    /// </summary>
    public static class ThermodynamicsExtensions
    {
        /// <summary>
        /// Creates the serializable temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <returns>A new serializable <see cref="Temperature" />.</returns>
        public static Temperature ToSerializable(this Quantities.Thermodynamics.Temperature temperature)
        {
            return new Temperature(temperature);
        }
    }
}