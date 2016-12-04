// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousFlux.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.LuminousFlux"/> as a serializable type.
    /// </summary>
    public class LuminousFlux : SerializableQuantity<Quantities.LuminousFlux>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        public LuminousFlux()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public LuminousFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.LuminousFlux"/>.
        /// </returns>
        public override Quantities.LuminousFlux ToQuantity()
        {
            return new Quantities.LuminousFlux(this.Value, this.GetUnit());
        }
    }
}