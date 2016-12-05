// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivedUnit.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Units
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Expressions.Visitors;

    /// <summary>
    /// Represents a base unit.
    /// </summary>
    public class DerivedUnit : IUnit
    {
        private readonly DerivedBaseUnit derivedBaseUnit;

        private readonly Expression expression;

        private readonly string notation;

        private readonly Prefix prefix;

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedUnit" /> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        public DerivedUnit(Prefix prefix, string notation, Expression expression)
        {
            this.prefix = prefix ?? Prefix.None;
            this.notation = notation;
            this.expression = expression;
            this.derivedBaseUnit = new DerivedBaseUnit(expression);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedUnit" /> class.
        /// </summary>
        /// <param name="notation">The notation.</param>
        /// <param name="expression">The expression.</param>
        public DerivedUnit(string notation, Expression expression)
            : this(null, notation, expression)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedUnit" /> class.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public DerivedUnit(Expression expression)
            : this(null, null, expression)
        {
        }

        /// <summary>
        /// Gets the prefix factor.
        /// </summary>
        /// <value>The prefix.</value>
        public double PrefixFactor =>
                this.HasOwnNotation
                    ? this.prefix.Factor
                    : this.prefix.Factor * DefaultVisitors.PrefixVisitor.Visit(this.expression);

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>The notation.</value>
        public string Notation => this.GetNotation(CultureInfo.CurrentCulture);

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>The base unit.</value>
        public IUnit BaseUnit => this.derivedBaseUnit;

        /// <summary>
        /// Gets a value indicating whether the <see cref="DerivedUnit"/> has its own notation.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [has own notation]; otherwise, <c>false</c>.
        /// </value>
        private bool HasOwnNotation => this.notation != null;

        /// <summary>
        /// Gets the expression for the specified unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public static implicit operator Expression(DerivedUnit unit)
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
            return this.prefix.ToBase(DefaultVisitors.ValueToBaseVisitor.Visit(this.expression, value));
        }

        /// <summary>
        /// Converts the specified value from the SI base value into the unit value.
        /// </summary><param name="value">The value.
        /// </param>
        /// <returns>The unit's value.</returns>
        public double FromBase(double value)
        {
            return this.prefix.FromBase(DefaultVisitors.ValueFromBaseVisitor.Visit(this.expression, value));
        }

        /// <summary>
        /// The expression.
        /// </summary>
        /// <returns>The <see cref="Expression" />.</returns>
        public Expression GetExpression()
        {
            return this.HasOwnNotation ? new UnitExpression(this) : this.expression;
        }

        /// <summary>
        /// Gets the prefixed unit.
        /// </summary>
        /// <param name="newPrefix">The prefix.</param>
        /// <returns>A new <see cref="IUnit"/> with the specified <see cref="Prefix"/>.</returns>
        public IUnit GetPrefixedUnit(Prefix newPrefix)
        {
            return new DerivedUnit(newPrefix, this.notation, this.expression);
        }

        /// <summary>
        /// Gets the notation without prefix.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The notation without a prefix.</returns>
        public string GetNotationWithoutPrefix(IFormatProvider formatProvider = null)
        {
            return this.notation ?? this.GetBaseNotation(formatProvider);
        }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
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
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">
        /// An object to compare with this object.
        /// </param>
        /// <returns>
        ///     <c>true</c> if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        public bool Equals(IUnit other)
        {
            return UnitEqualityHelper.AreUnitsEqual(this, other);
        }

        /// <summary>
        /// The base expression.
        /// </summary>
        /// <returns>The <see cref="Expression" />.</returns>
        public Expression GetBaseExpression()
        {
            return this.derivedBaseUnit.GetExpression();
        }

        /// <summary>
        /// Gets the base notation.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The base notation.</returns>
        public string GetBaseNotation(IFormatProvider formatProvider = null)
        {
            return DefaultVisitors.NotationVisitor.Visit(this.expression, formatProvider ?? CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return UnitEqualityHelper.GetHashCode(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object"/>, is equal to this instance.
        /// </summary>
        /// <param name="other">
        /// The <see cref="object"/> to compare with this instance.
        /// </param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object other)
        {
            return UnitEqualityHelper.AreUnitsEqual(this, other);
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Notation;
        }
    }
}