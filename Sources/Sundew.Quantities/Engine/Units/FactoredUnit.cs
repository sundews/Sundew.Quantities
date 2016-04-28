namespace Sundew.Quantities.Engine.Units
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Globalization;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Implementation of <see cref="IUnit"/> without a prefix.
    /// </summary>
    public class FactoredUnit : IUnit
    {
        private const string UnitFactorFormat = "{0}";

        private readonly Prefix prefix;

        private readonly string notation;

        private readonly Expression expression;

        private readonly double unitFactor;

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoredUnit" /> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="unitFactor">The unit factor.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        public FactoredUnit(Prefix prefix, double unitFactor, string notation, Expression expression)
            : this(prefix, unitFactor, notation, expression, new DerivedBaseUnit(expression))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoredUnit" /> class.
        /// </summary>
        /// <param name="unitFactor">The unit factor.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        public FactoredUnit(double unitFactor, string notation, Expression expression)
            : this(null, unitFactor, notation, expression)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoredUnit" /> class.
        /// </summary>
        /// <param name="unitFactor">The unit factor.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="prefixedBaseUnit">The expression.</param>
        public FactoredUnit(double unitFactor, string notation, PrefixedBaseUnit prefixedBaseUnit)
            : this(null, unitFactor, notation, prefixedBaseUnit, prefixedBaseUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoredUnit" /> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="unitFactor">The unit factor.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="baseUnit">The base unit.</param>
        private FactoredUnit(Prefix prefix, double unitFactor, string notation, Expression expression, IUnit baseUnit)
        {
            this.prefix = prefix ?? Prefix.None;
            this.unitFactor = unitFactor;
            this.notation = notation;
            this.expression = expression;
            this.BaseUnit = baseUnit;
        }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>The notation.</value>
        public string Notation => this.GetNotation(CultureInfo.CurrentCulture);

        /// <summary>
        /// Gets the prefix factor.
        /// </summary>
        /// <value>The prefix.</value>
        public double PrefixFactor => this.prefix.Factor;

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>The base unit.</value>
        public IUnit BaseUnit { get; }

        /// <summary>
        /// Gets the expression for the specified unit.
        /// </summary>
        /// <param name="factoredUnit">The unit.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public static implicit operator Expression(FactoredUnit factoredUnit)
        {
            Contract.Requires(factoredUnit != null);
            return factoredUnit.GetExpression();
        }

        /// <summary>
        /// Converts the specified value into the unit's base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The unit's base value.
        /// </returns>
        public double ToBase(double value)
        {
            return this.prefix.ToBase(value * this.unitFactor);
        }

        /// <summary>
        /// Converts the specified value from the SI base value into the unit value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The unit's value.
        /// </returns>
        public double FromBase(double value)
        {
            return this.prefix.FromBase(value / this.unitFactor);
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        /// <returns>
        /// An <see cref="Expression" />.
        /// </returns>
        public Expression GetExpression()
        {
            return new UnitExpression(this);
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
            return new FactoredUnit(newPrefix, this.unitFactor, this.notation, this.expression);
        }

        /// <summary>
        /// Gets the notation without prefix.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// The notation without a prefix.
        /// </returns>
        public string GetNotationWithoutPrefix(IFormatProvider formatProvider = null)
        {
            if (string.IsNullOrEmpty(this.notation))
            {
                return string.Format(formatProvider ?? CultureInfo.CurrentCulture, UnitFactorFormat, this.unitFactor);
            }

            return this.notation;
        }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <returns>The notation.</returns>
        public string GetNotation(IFormatProvider formatProvider = null)
        {
            return this.prefix.GetPrefixedNotation(this.GetNotationWithoutPrefix(formatProvider));
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