// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Angle.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Spatial
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spatial.Angle"/> as a serializable type.
    /// </summary>
    public class Angle : SerializableQuantity<Quantities.Spatial.Angle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Angle"/> class.
        /// </summary>
        public Angle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Angle(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Spatial.Angle" />.
        /// </returns>
        public override Quantities.Spatial.Angle ToQuantity()
        {
            return new Quantities.Spatial.Angle(this.Value, this.GetUnit());
        }
    }
}