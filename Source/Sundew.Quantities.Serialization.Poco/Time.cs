// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Time.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Quantities.Time"/> as a serializable type.
    /// </summary>
    public sealed class Time : SerializableQuantity<Quantities.Time>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Time(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Quantities.Time"/>.</returns>
        public override Quantities.Time ToQuantity()
        {
            return new Quantities.Time(this.Value, this.GetUnit());
        }
    }
}