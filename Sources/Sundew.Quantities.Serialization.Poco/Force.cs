// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Force.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Force"/> as a serializable type.
    /// </summary>
    public class Force : SerializableQuantity<Quantities.Force>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Force"/> class.
        /// </summary>
        public Force()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Force" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Force(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A new <see cref="Force"/>.</returns>
        public override Quantities.Force ToQuantity()
        {
            return new Quantities.Force(this.Value, this.GetUnit());
        }
    }
}