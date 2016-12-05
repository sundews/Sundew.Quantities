// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SerializableQuantity.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco
{
    using System.Globalization;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.Parsing;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Abstract base class for implementing a serializable quantity.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public abstract class SerializableQuantity<TQuantity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableQuantity{TQuantity}"/> class.
        /// </summary>
        protected SerializableQuantity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableQuantity{TQuantity}" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        protected SerializableQuantity(IQuantity quantity)
        {
            this.Value = quantity.Value;
            this.Unit = quantity.Unit.GetNotation(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>
        /// The unit as a <see cref="string"/>.
        /// </value>
        public string Unit { get; set; }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="TQuantity"/>.</returns>
        public abstract TQuantity ToQuantity();

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <returns>An <see cref="IUnit"/>.</returns>
        protected IUnit GetUnit()
        {
            return UnitSystem.GetUnitFrom(this.Unit, ParseSettings.DefaultInvariantCulture).Value;
        }
    }
}