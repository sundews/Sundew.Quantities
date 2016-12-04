// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Frequency.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Quantities.Frequency"/> as a serializable type.
    /// </summary>
    public class Frequency : SerializableQuantity<Quantities.Frequency>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frequency"/> class.
        /// </summary>
        public Frequency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Frequency"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Frequency(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Quantities.Frequency"/>.
        /// </returns>
        public override Quantities.Frequency ToQuantity()
        {
            return new Quantities.Frequency(this.Value, this.GetUnit());
        }
    }
}