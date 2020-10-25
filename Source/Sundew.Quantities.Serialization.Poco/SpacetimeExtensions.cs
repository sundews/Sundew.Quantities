// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpacetimeExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Serialization extension methods for spacetime quantities.
    /// </summary>
    public static class SpacetimeExtensions
    {
        /// <summary>
        /// Creates the serializable acceleration.
        /// </summary>
        /// <param name="acceleration">The acceleration.</param>
        /// <returns>A new serializable <see cref="Acceleration" />.</returns>
        public static Acceleration ToSerializable(this Quantities.Acceleration acceleration)
        {
            return new Acceleration(acceleration);
        }

        /// <summary>
        /// Creates the serializable velocity.
        /// </summary>
        /// <param name="velocity">The velocity.</param>
        /// <returns>A new serializable <see cref="Velocity" />.</returns>
        public static Velocity ToSerializable(this Quantities.Velocity velocity)
        {
            return new Velocity(velocity);
        }
    }
}