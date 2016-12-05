// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SolidAngle.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.SolidAngle"/> as a serializable type.
    /// </summary>
    public class SolidAngle : SerializableQuantity<Quantities.SolidAngle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle"/> class.
        /// </summary>
        public SolidAngle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public SolidAngle(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.SolidAngle" />.
        /// </returns>
        public override Quantities.SolidAngle ToQuantity()
        {
            return new Quantities.SolidAngle(this.Value, this.GetUnit());
        }
    }
}