// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volume.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Volume" /> as a serializable type.
    /// </summary>
    public sealed class Volume : SerializableQuantity<Quantities.Volume>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        public Volume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Volume(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instance to a quantity.
        /// </summary>
        /// <returns>A new <see cref="Sundew.Quantities.Volume"/>.</returns>
        public override Quantities.Volume ToQuantity()
        {
            return new Quantities.Volume(this.Value, this.GetUnit());
        }
    }
}