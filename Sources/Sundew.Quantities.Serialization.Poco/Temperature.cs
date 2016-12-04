// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Temperature.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Temperature"/> as a serializable type.
    /// </summary>
    public class Temperature : SerializableQuantity<Quantities.Temperature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        public Temperature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Temperature(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Thermodynamics.Temperature" />.
        /// </returns>
        public override Quantities.Temperature ToQuantity()
        {
            return new Quantities.Temperature(this.Value, this.GetUnit());
        }
    }
}