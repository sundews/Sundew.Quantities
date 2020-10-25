// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectricCurrent.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.ElectricCurrent"/> as a serializable type.
    /// </summary>
    public class ElectricCurrent : SerializableQuantity<Quantities.ElectricCurrent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent"/> class.
        /// </summary>
        public ElectricCurrent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public ElectricCurrent(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable electric current to a quantity electric current.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.ElectricCurrent"/>.</returns>
        public override Quantities.ElectricCurrent ToQuantity()
        {
            return new Quantities.ElectricCurrent(this.Value, this.GetUnit());
        }
    }
}