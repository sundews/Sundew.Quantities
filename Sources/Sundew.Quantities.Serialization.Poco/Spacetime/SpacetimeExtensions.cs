// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SpacetimeExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Spacetime
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
        public static Acceleration ToSerializable(this Quantities.Spacetime.Acceleration acceleration)
        {
            return new Acceleration(acceleration);
        }

        /// <summary>
        /// Creates the serializable velocity.
        /// </summary>
        /// <param name="velocity">The velocity.</param>
        /// <returns>A new serializable <see cref="Velocity" />.</returns>
        public static Velocity ToSerializable(this Quantities.Spacetime.Velocity velocity)
        {
            return new Velocity(velocity);
        }
    }
}