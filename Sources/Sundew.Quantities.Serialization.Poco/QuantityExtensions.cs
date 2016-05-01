// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Serialization extension methods for <see cref="Quantity"/>.
    /// </summary>
    public static class QuantityExtensions
    {
        /// <summary>
        /// Creates the serializable.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>A new serializable <see cref="Quantity" />.</returns>
        public static Quantity ToSerializable(this Quantities.Quantity quantity)
        {
            return new Quantity(quantity);
        }
    }
}