// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mass.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mass"/> as a serializable type.
    /// </summary>
    public sealed class Mass : SerializableQuantity<Quantities.Mass>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        public Mass()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Mass(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Mass"/>.</returns>
        public override Quantities.Mass ToQuantity()
        {
            return new Quantities.Mass(this.Value, this.GetUnit());
        }
    }
}