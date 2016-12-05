// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Resistance.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Resistance"/> as a serializable type.
    /// </summary>
    public class Resistance : SerializableQuantity<Quantities.Resistance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance"/> class.
        /// </summary>
        public Resistance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Resistance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Resistance" />.
        /// </returns>
        public override Quantities.Resistance ToQuantity()
        {
            return new Quantities.Resistance(this.Value, this.GetUnit());
        }
    }
}