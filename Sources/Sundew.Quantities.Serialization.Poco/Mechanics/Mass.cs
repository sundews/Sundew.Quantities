// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Mass.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mechanics.Mass"/> as a serializable type.
    /// </summary>
    public sealed class Mass : SerializableQuantity<Quantities.Mechanics.Mass>
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
        /// <returns>A <see cref="Sundew.Quantities.Mechanics.Mass"/>.</returns>
        public override Quantities.Mechanics.Mass ToQuantity()
        {
            return new Quantities.Mechanics.Mass(this.Value, this.GetUnit());
        }
    }
}