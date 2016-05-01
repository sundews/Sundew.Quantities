// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Frequency.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Periodics
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Quantities.Periodics.Frequency"/> as a serializable type.
    /// </summary>
    public class Frequency : SerializableQuantity<Quantities.Periodics.Frequency>
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
        /// A <see cref="Quantities.Periodics.Frequency"/>.
        /// </returns>
        public override Quantities.Periodics.Frequency ToQuantity()
        {
            return new Quantities.Periodics.Frequency(this.Value, this.GetUnit());
        }
    }
}