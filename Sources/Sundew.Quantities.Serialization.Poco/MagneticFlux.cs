// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagneticFlux.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.MagneticFlux"/> as a serializable type.
    /// </summary>
    public class MagneticFlux : SerializableQuantity<Quantities.MagneticFlux>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux"/> class.
        /// </summary>
        public MagneticFlux()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public MagneticFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.MagneticFlux" />.
        /// </returns>
        public override Quantities.MagneticFlux ToQuantity()
        {
            return new Quantities.MagneticFlux(this.Value, this.GetUnit());
        }
    }
}