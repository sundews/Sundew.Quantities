// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Acceleration.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Acceleration" /> as a serializable type.
    /// </summary>
    public sealed class Acceleration : SerializableQuantity<Quantities.Acceleration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        public Acceleration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Acceleration(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Acceleration"/>.</returns>
        public override Quantities.Acceleration ToQuantity()
        {
            return new Quantities.Acceleration(this.Value, this.GetUnit());
        }
    }
}