namespace Sundew.Quantities.Engine.Units
{
    using System;
    using System.Diagnostics.Contracts;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Represents a unit, which has the units base notation, but which is not a base unit.
    /// </summary>
    public class NotationBaseUnit : IUnit
    {
        private readonly Prefix prefix;

        private readonly string notation;

        private readonly PrefixedBaseUnit prefixedBaseUnit;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotationBaseUnit"/> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="prefixedBaseUnit">The prefixed base unit.</param>
        public NotationBaseUnit(Prefix prefix, string notation, PrefixedBaseUnit prefixedBaseUnit)
        {
            this.prefix = prefix ?? Prefix.None;
            this.notation = notation;
            this.prefixedBaseUnit = prefixedBaseUnit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotationBaseUnit"/> class.
        /// </summary>
        /// <param name="notation">The notation.</param>
        /// <param name="prefixedBaseUnit">The prefixed base unit.</param>
        public NotationBaseUnit(string notation, PrefixedBaseUnit prefixedBaseUnit)
            : this(null, notation, prefixedBaseUnit)
        {
        }

        /// <summary>
        /// Gets the prefix factor.
        /// </summary>
        /// <value>The prefix.</value>
        public double PrefixFactor => this.prefix.Factor / this.prefixedBaseUnit.Prefix.Factor;

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>The notation.</value>
        public string Notation => this.GetNotation();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>The base unit.</value>
        public IUnit BaseUnit => this.prefixedBaseUnit;

        /// <summary>
        /// Gets the expression for the specified unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public static implicit operator Expression(NotationBaseUnit unit)
        {
            Contract.Requires(unit != null);
            return unit.GetExpression();
        }

        /// <summary>
        /// Converts the specified value into the unit's base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The unit's base value.</returns>
        public double ToBase(double value)
        {
            return this.prefix.ToBase(this.prefixedBaseUnit.ToBase(value) / this.prefixedBaseUnit.Prefix.Factor);
        }

        /// <summary>
        /// Converts the specified value from the SI base value into the unit value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The unit's value.</returns>
        public double FromBase(double value)
        {
            return this.prefix.FromBase(this.prefixedBaseUnit.FromBase(value) * this.prefixedBaseUnit.Prefix.Factor);
        }

        /// <summary>
        /// Gets the expression.
        /// </summary><returns>An <see cref="Expression" />.</returns>
        public Expression GetExpression()
        {
            return new UnitExpression(this);
        }

        /// <summary>
        /// Gets the base expression.
        /// </summary>
        /// <returns>The base <see cref="Expression" />.</returns>
        public Expression GetBaseExpression()
        {
            return this.prefixedBaseUnit.GetExpression();
        }

        /// <summary>
        /// Gets the prefixed unit.
        /// </summary>
        /// <param name="newPrefix">The prefix.</param>
        /// <returns>A new <see cref="IUnit"/> with the specified <see cref="Prefix"/>.</returns>
        public IUnit GetPrefixedUnit(Prefix newPrefix)
        {
            if (newPrefix.Equals(this.prefixedBaseUnit.Prefix))
            {
                return this.prefixedBaseUnit;
            }

            return new NotationBaseUnit(newPrefix, this.Notation, this.prefixedBaseUnit);
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
        /// Gets the base notation.
        /// </summary>
        /// <returns>The base notation.</returns>
        public string GetBaseNotation()
        {
            return this.prefixedBaseUnit.Notation;
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
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            return UnitHelper.GetHashCode(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/>, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object other)
        {
            return UnitHelper.AreUnitsEqual(this, other);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        public bool Equals(IUnit other)
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