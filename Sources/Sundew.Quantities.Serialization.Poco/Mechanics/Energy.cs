// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Energy.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mechanics.Energy"/> as a serializable type.
    /// </summary>
    public class Energy : SerializableQuantity<Quantities.Mechanics.Energy>
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
        /// <returns>A <see cref="Sundew.Quantities.Mechanics.Energy"/>.</returns>
        public override Quantities.Mechanics.Energy ToQuantity()
        {
            return new Quantities.Mechanics.Energy(this.Value, this.GetUnit());
        }
    }
}