// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagneticFlux.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.MagneticFlux"/> as a serializable type.
    /// </summary>
    public class MagneticFlux : SerializableQuantity<Quantities.MagneticFlux>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux"/> class.
        /// </summary>
        public MagneticFlux()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public MagneticFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.MagneticFlux" />.
        /// </returns>
        public override Quantities.MagneticFlux ToQuantity()
        {
            return new Quantities.MagneticFlux(this.Value, this.GetUnit());
        }
    }
}