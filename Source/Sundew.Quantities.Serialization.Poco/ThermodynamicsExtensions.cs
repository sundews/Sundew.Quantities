// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThermodynamicsExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
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
        public static Temperature ToSerializable(this Quantities.Temperature temperature)
        {
            return new Temperature(temperature);
        }
    }
}