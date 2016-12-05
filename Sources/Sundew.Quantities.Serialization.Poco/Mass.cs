// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Mass.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mass"/> as a serializable type.
    /// </summary>
    public sealed class Mass : SerializableQuantity<Quantities.Mass>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        public Mass()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Mass(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Mass"/>.</returns>
        public override Quantities.Mass ToQuantity()
        {
            return new Quantities.Mass(this.Value, this.GetUnit());
        }
    }
}