// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Volume.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Spatial
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spatial.Volume" /> as a serializable type.
    /// </summary>
    public sealed class Volume : SerializableQuantity<Quantities.Spatial.Volume>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        public Volume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Volume(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instance to a quantity.
        /// </summary>
        /// <returns>A new <see cref="Sundew.Quantities.Spatial.Volume"/>.</returns>
        public override Quantities.Spatial.Volume ToQuantity()
        {
            return new Quantities.Spatial.Volume(this.Value, this.GetUnit());
        }
    }
}