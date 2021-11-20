// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrefixedBaseUnit.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Units;

using System;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Implementation of <see cref="IUnit"/> for supporting units like kg, which is a base unit, but has a prefix.
/// </summary>
public class PrefixedBaseUnit : IUnit
{
    private readonly string notation;

    private readonly Prefix prefix;

    private readonly UnitExpression unitExpression;

    /// <summary>
    /// Initializes a new instance of the <see cref="PrefixedBaseUnit" /> class.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    /// <param name="notation">The notation.</param>
    public PrefixedBaseUnit(Prefix prefix, string notation)
    {
        this.prefix = prefix;
        this.notation = notation;
        this.unitExpression = new UnitExpression(this);
    }

    /// <summary>
    /// Gets the prefix.
    /// </summary>
    /// <value>
    /// The prefix.
    /// </value>
    public Prefix Prefix => this.prefix;

    /// <summary>
    /// Gets the prefix factor.
    /// </summary>
    /// <value>
    /// The prefix.
    /// </value>
    public double PrefixFactor => 1;

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
    public IUnit BaseUnit => this;

    /// <summary>
    /// Gets the expression for the specified unit.
    /// </summary>
    /// <param name="unit">The unit.</param>
    /// <returns>An <see cref="Expression"/>.</returns>
    public static implicit operator Expression(PrefixedBaseUnit unit)
    {
        return unit.GetExpression();
    }

    /// <summary>
    /// Multiplies the specified LHS with the RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>A <see cref="DerivedUnit"/>.</returns>
    public static Expression operator *(PrefixedBaseUnit lhs, IUnit rhs)
    {
        return lhs.GetExpression() * rhs.GetExpression();
    }

    /// <summary>
    /// Multiplies the specified LHS with the RHS.
    /// </summary>
    /// <param name="lhs">The LHS.</param>
    /// <param name="rhs">The RHS.</param>
    /// <returns>A <see cref="DerivedUnit"/>.</returns>
    public static Expression operator /(PrefixedBaseUnit lhs, IUnit rhs)
    {
        return lhs.GetExpression() / rhs.GetExpression();
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
        return value;
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
        return value;
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
        if (this.prefix.Equals(newPrefix))
        {
            return this;
        }

        return new NotationBaseUnit(newPrefix, this.notation, this);
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
        return this.notation;
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
        return UnitEqualityHelper.AreUnitsEqual(this, other);
    }

    /// <summary>
    /// Gets the base expression.
    /// </summary>
    /// <returns>
    /// the base <see cref="Expression" />.
    /// </returns>
    public Expression GetBaseExpression()
    {
        return this.GetExpression();
    }

    /// <summary>
    /// Gets the base notation.
    /// </summary>
    /// <returns>
    /// The base notation.
    /// </returns>
    public string GetBaseNotation()
    {
        return this.Notation;
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
    /// <param name="other">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
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