// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Area.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Area"/> as a serializable type.
    /// </summary>
    public sealed class Area : SerializableQuantity<Quantities.Area>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        public Area()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Area(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instance to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Area"/>.</returns>
        public override Quantities.Area ToQuantity()
        {
            return new Quantities.Area(this.Value, this.GetUnit());
        }
    }
}