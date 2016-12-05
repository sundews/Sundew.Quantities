// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Quantity.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Quantity"/> serializable type.
    /// </summary>
    public class Quantity : SerializableQuantity<Core.Quantity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        public Quantity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Quantity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Quantity" />.
        /// </returns>
        public override Core.Quantity ToQuantity()
        {
            return new Core.Quantity(this.Value, this.GetUnit());
        }
    }
}