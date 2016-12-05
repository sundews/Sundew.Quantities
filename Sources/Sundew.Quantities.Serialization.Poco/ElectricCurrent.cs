// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ElectricCurrent.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.ElectricCurrent"/> as a serializable type.
    /// </summary>
    public class ElectricCurrent : SerializableQuantity<Quantities.ElectricCurrent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent"/> class.
        /// </summary>
        public ElectricCurrent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public ElectricCurrent(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable electric current to a quantity electric current.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.ElectricCurrent"/>.</returns>
        public override Quantities.ElectricCurrent ToQuantity()
        {
            return new Quantities.ElectricCurrent(this.Value, this.GetUnit());
        }
    }
}