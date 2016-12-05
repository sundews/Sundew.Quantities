// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Volume.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Volume" /> as a serializable type.
    /// </summary>
    public sealed class Volume : SerializableQuantity<Quantities.Volume>
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
        /// <returns>A new <see cref="Sundew.Quantities.Volume"/>.</returns>
        public override Quantities.Volume ToQuantity()
        {
            return new Quantities.Volume(this.Value, this.GetUnit());
        }
    }
}