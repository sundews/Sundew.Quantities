// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Distance" /> as a serializable type.
    /// </summary>
    public sealed class Distance : SerializableQuantity<Quantities.Distance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        public Distance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Distance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Distance"/>.</returns>
        public override Quantities.Distance ToQuantity()
        {
            return new Quantities.Distance(this.Value, this.GetUnit());
        }
    }
}