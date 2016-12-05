// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Power.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Power"/> as a serializable type.
    /// </summary>
    public class Power : SerializableQuantity<Quantities.Power>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        public Power()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Power(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Power"/>.</returns>
        public override Quantities.Power ToQuantity()
        {
            return new Quantities.Power(this.Value, this.GetUnit());
        }
    }
}