// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Resistance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Resistance"/> as a serializable type.
    /// </summary>
    public class Resistance : SerializableQuantity<Quantities.Resistance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance"/> class.
        /// </summary>
        public Resistance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Resistance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Resistance" />.
        /// </returns>
        public override Quantities.Resistance ToQuantity()
        {
            return new Quantities.Resistance(this.Value, this.GetUnit());
        }
    }
}