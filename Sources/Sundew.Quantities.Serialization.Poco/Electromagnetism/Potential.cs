// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Potential.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.Potential"/> as a serializable type.
    /// </summary>
    public class Potential : SerializableQuantity<Quantities.Electromagnetism.Potential>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Potential"/> class.
        /// </summary>
        public Potential()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Potential" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Potential(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable potential to a quantity potential.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Electromagnetism.Charge"/>.</returns>
        public override Quantities.Electromagnetism.Potential ToQuantity()
        {
            return new Quantities.Electromagnetism.Potential(this.Value, this.GetUnit());
        }
    }
}