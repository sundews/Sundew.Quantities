// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Angle.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Angle"/> as a serializable type.
    /// </summary>
    public class Angle : SerializableQuantity<Quantities.Angle>
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
        /// A <see cref="Sundew.Quantities.Angle" />.
        /// </returns>
        public override Quantities.Angle ToQuantity()
        {
            return new Quantities.Angle(this.Value, this.GetUnit());
        }
    }
}