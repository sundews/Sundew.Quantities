namespace Sundew.Quantities.Engine.Units
{
    using System;
    using System.Globalization;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;

    /// <summary>
    /// Represents the base unit of a <see cref="DerivedUnit"/>.
    /// </summary>
    internal class DerivedBaseUnit : IUnit
    {
        private readonly Expression baseExpression;

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedBaseUnit"/> class.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public DerivedBaseUnit(Expression expression)
        {
            this.baseExpression = DefaultVisitors.BaseExpressionVisitor.Visit(expression);
        }

        /// <summary>
        /// Gets the prefix factor.
        /// </summary>
        /// <value>The prefix factor.</value>
        public double PrefixFactor => 1;

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>
        /// The notation.
        /// </value>
        public string Notation => this.GetNotation(CultureInfo.CurrentCulture); 

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>The base unit.</value>
        public IUnit BaseUnit => this;

        /// <summary>
        /// To the base.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The same value.</returns>
        public double ToBase(double value)
        {
            return value;
        }

        /// <summary>
        /// Froms the base.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The same value.</returns>
        public double FromBase(double value)
        {
            return value;
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        /// <returns>The expression.</returns>
        public Expression GetExpression()
        {
            return this.baseExpression;
        }

        /// <summary>
        /// Gets the prefixed unit.
        /// </summary>
        /// <param name="newPrefix">The new prefix.</param>
        /// <returns>A <see cref="DerivedUnit"/> with the new <see cref="Prefix"/>.</returns>
        public IUnit GetPrefixedUnit(Prefix newPrefix)
        {
            return new DerivedUnit(newPrefix, null, this.baseExpression);
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
            return DefaultVisitors.NotationVisitor.Visit(this.GetExpression(), formatProvider ?? CultureInfo.CurrentCulture);
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
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return UnitHelper.AreUnitsEqual(this, obj);
        }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
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