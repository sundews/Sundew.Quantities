// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousIntensity.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.LuminousIntensity"/> as a serializable type.
    /// </summary>
    public class LuminousIntensity : SerializableQuantity<Quantities.LuminousIntensity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousIntensity"/> class.
        /// </summary>
        public LuminousIntensity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousIntensity"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public LuminousIntensity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.LuminousIntensity"/>.
        /// </returns>
        public override Quantities.LuminousIntensity ToQuantity()
        {
            return new Quantities.LuminousIntensity(this.Value, this.GetUnit());
        }
    }
}