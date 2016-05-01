// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousIntensity.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Photometry
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Photometry.LuminousIntensity"/> as a serializable type.
    /// </summary>
    public class LuminousIntensity : SerializableQuantity<Quantities.Photometry.LuminousIntensity>
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
        /// A <see cref="Sundew.Quantities.Photometry.LuminousIntensity"/>.
        /// </returns>
        public override Quantities.Photometry.LuminousIntensity ToQuantity()
        {
            return new Quantities.Photometry.LuminousIntensity(this.Value, this.GetUnit());
        }
    }
}