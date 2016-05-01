// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MethodUnit.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Units
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// A unit for implementing units with a custom conversion to their base unit.
    /// </summary>
    public class MethodUnit : IUnit
    {
        private readonly Expression expression;

        private readonly Func<double, double> fromBase;

        private readonly string notation;

        private readonly Prefix prefix;

        private readonly Func<double, double> toBase;

        private readonly UnitExpression unitExpression;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodUnit" /> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="toBase">To base.</param>
        /// <param name="fromBase">From base.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        public MethodUnit(
            Prefix prefix,
            Func<double, double> toBase,
            Func<double, double> fromBase,
            string notation,
            Expression expression)
        {
            this.prefix = prefix ?? Prefix.None;
            this.toBase = toBase;
            this.fromBase = fromBase;
            this.notation = notation;
            this.expression = expression;
            this.BaseUnit = new DerivedBaseUnit(expression);
            this.unitExpression = new UnitExpression(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodUnit" /> class.
        /// </summary>
        /// <param name="toBase">To base.</param>
        /// <param name="fromBase">From base.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        public MethodUnit(
            Func<double, double> toBase,
            Func<double, double> fromBase,
            string notation,
            Expression expression)
            : this(null, toBase, fromBase, notation, expression)
        {
        }

        /// <summary>
        /// Gets the prefix factor.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public double PrefixFactor => this.prefix.Factor;

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>
        /// The notation.
        /// </value>
        public string Notation => this.GetNotation();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public IUnit BaseUnit { get; }

        /// <summary>
        /// Converts the specified value into the unit's base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The unit's base value.
        /// </returns>
        public double ToBase(double value)
        {
            return this.toBase(value);
        }

        /// <summary>
        /// Converts the specified value from the SI base value into the unit value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The unit's value.</returns>
        public double FromBase(double value)
        {
            return this.fromBase(value);
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        /// <returns>
        /// An <see cref="Expression" />.
        /// </returns>
        public Expression GetExpression()
        {
            return this.unitExpression;
        }

        /// <summary>
        /// Gets the prefixed unit.
        /// </summary>
        /// <param name="newPrefix">The prefix.</param>
        /// <returns>
        /// A new <see cref="IUnit" /> with the specified <see cref="Prefix" />.
        /// </returns>
        public IUnit GetPrefixedUnit(Prefix newPrefix)
        {
            return new MethodUnit(newPrefix, this.toBase, this.fromBase, this.notation, this.expression);
        }

        /// <summary>
        /// Gets the notation without prefix.
        /// </summary>
        /// <returns>The notation without a prefix.</returns>
        public string GetNotationWithoutPrefix(IFormatProvider formatProvider = null)
        {
            return this.GetNotation(formatProvider);
        }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The notation.</returns>
        public string GetNotation(IFormatProvider formatProvider = null)
        {
            return this.prefix.GetPrefixedNotation(this.notation);
        }

        /// <summary>
        /// Formats the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The formatted value.</returns>
        public string FormatValue(double value, string format, IFormatProvider formatProvider)
        {
            return value.ToString(format, formatProvider);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(IUnit other)
        {
            return UnitHelper.AreUnitsEqual(this, other);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return UnitHelper.GetHashCode(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/>, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object other)
        {
            return UnitHelper.AreUnitsEqual(this, other);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Notation;
        }
    }
}