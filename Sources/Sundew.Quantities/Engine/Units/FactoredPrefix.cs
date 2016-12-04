// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoredPrefix.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Units
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Represents a prefix for a unit.
    /// </summary>
    public class FactoredPrefix : Prefix
    {
        private readonly double factor;

        private readonly string notation;

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoredPrefix" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="factor">The factor.</param>
        /// <param name="notation">The notation.</param>
        internal FactoredPrefix(string name, double factor, string notation)
        {
            this.Name = name;
            this.factor = factor;
            this.notation = notation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoredPrefix"/> class.
        /// </summary>
        /// <param name="factor">The factor.</param>
        internal FactoredPrefix(double factor)
            : this(factor.ToString(), factor, string.Empty)
        {
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; }

        /// <summary>
        /// Gets the factor.
        /// </summary>
        /// <value>
        /// The factor.
        /// </value>
        public override double Factor => this.factor;

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>
        /// The notation.
        /// </value>
        public override string Notation => this.notation;

        /// <summary>
        /// Gets the prefixed notation.
        /// </summary>
        /// <param name="unitNotation">The notation.</param>
        /// <returns>
        /// The prefixed notation.
        /// </returns>
        public override string GetPrefixedNotation(string unitNotation)
        {
            return this.notation + unitNotation;
        }

        /// <summary>
        /// From the base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The value for the prefix.
        /// </returns>
        public override double FromBase(double value)
        {
            return value / this.factor;
        }

        /// <summary>
        /// To the base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The base value.
        /// </returns>
        public override double ToBase(double value)
        {
            return value * this.factor;
        }
    }
}