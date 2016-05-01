// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SpatialExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Spatial
{
    /// <summary>
    /// Serialization extension methods for spatial quantities.
    /// </summary>
    public static class SpatialExtensions
    {
        /// <summary>
        /// Creates the serializable angle.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>A new serializable <see cref="Angle" />.</returns>
        public static Angle ToSerializable(this Quantities.Spatial.Angle angle)
        {
            return new Angle(angle);
        }

        /// <summary>
        /// Creates the serializable area.
        /// </summary>
        /// <param name="area">The area quantity.</param>
        /// <returns>A new serializable <see cref="Area" />.</returns>
        public static Area ToSerializable(this Quantities.Spatial.Area area)
        {
            return new Area(area);
        }

        /// <summary>
        /// Creates the serializable distance.
        /// </summary>
        /// <param name="distance">The distance quantity.</param>
        /// <returns>A new serializable <see cref="Distance"/>.</returns>
        public static Distance ToSerializable(this Quantities.Spatial.Distance distance)
        {
            return new Distance(distance);
        }

        /// <summary>
        /// Creates the serializable solid angle.
        /// </summary>
        /// <param name="solidAngle">The solid angle.</param>
        /// <returns>A new serializable <see cref="SolidAngle" />.</returns>
        public static SolidAngle ToSerializable(this Quantities.Spatial.SolidAngle solidAngle)
        {
            return new SolidAngle(solidAngle);
        }

        /// <summary>
        /// Creates the serializable volume.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <returns>A new serializable <see cref="Volume" />.</returns>
        public static Volume ToSerializable(this Quantities.Spatial.Volume volume)
        {
            return new Volume(volume);
        }
    }
}