// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Distance.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Distance" /> as a serializable type.
    /// </summary>
    public sealed class Distance : SerializableQuantity<Quantities.Distance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        public Distance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Distance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Spatial.Distance"/>.</returns>
        public override Quantities.Distance ToQuantity()
        {
            return new Quantities.Distance(this.Value, this.GetUnit());
        }
    }
}