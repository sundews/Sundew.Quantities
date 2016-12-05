// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Energy.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Energy"/> as a serializable type.
    /// </summary>
    public class Energy : SerializableQuantity<Quantities.Energy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Energy"/> class.
        /// </summary>
        public Energy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Energy"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Energy(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Energy"/>.</returns>
        public override Quantities.Energy ToQuantity()
        {
            return new Quantities.Energy(this.Value, this.GetUnit());
        }
    }
}