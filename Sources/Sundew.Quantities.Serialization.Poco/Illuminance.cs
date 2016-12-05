// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Illuminance.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Illuminance"/> as a serializable type.
    /// </summary>
    public class Illuminance : SerializableQuantity<Quantities.Illuminance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        public Illuminance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Illuminance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Illuminance"/>.
        /// </returns>
        public override Quantities.Illuminance ToQuantity()
        {
            return new Quantities.Illuminance(this.Value, this.GetUnit());
        }
    }
}