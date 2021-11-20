﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitFlatIdentifierRepresentation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Flat;

using System;
using System.Globalization;
using Sundew.Base.Equality;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Internals;

/// <summary>
/// Flat identifier representation for <see cref="UnitExpression"/>.
/// </summary>
public sealed class UnitFlatIdentifierRepresentation : IFlatIdentifierRepresentation,
    IEquatable<UnitFlatIdentifierRepresentation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitFlatIdentifierRepresentation"/> class.
    /// </summary>
    /// <param name="unitExpression">The unit expression.</param>
    /// <param name="exponent">The exponent.</param>
    public UnitFlatIdentifierRepresentation(UnitExpression unitExpression, double exponent)
    {
        this.Exponent = exponent;
        this.UnitExpression = unitExpression;
    }

    /// <summary>
    /// Gets the unit expression.
    /// </summary>
    /// <value>
    /// The unit expression.
    /// </value>
    public UnitExpression UnitExpression { get; }

    /// <summary>
    /// Gets the exponent.
    /// </summary>
    /// <value>
    /// The exponent.
    /// </value>
    public double Exponent { get; }

    /// <summary>
    /// A value indicating whether the specified instance is equal to this instance.
    /// </summary>
    /// <param name="other">The other.</param>
    /// <returns><c>true</c> if the instances are equal.</returns>
    public bool Equals(UnitFlatIdentifierRepresentation other)
    {
        return EqualityHelper.Equals(
            this,
            other,
            obj => this.UnitExpression.Equals(other.UnitExpression) && this.Exponent.Equals(obj.Exponent));
    }

    /// <summary>
    /// To the resulting expression.
    /// </summary>
    /// <returns>The resulting <see cref="Expression"/>.</returns>
    public Expression ToResultingExpression()
    {
        return FlatPresentationHelper.CreateResultingExpression(this.UnitExpression, this.Exponent);
    }

    /// <summary>
    /// A value indicating whether the specified instance is equal to this instance.
    /// </summary>
    /// <param name="other">The other.</param>
    /// <returns><c>true</c> if the instances are equal.</returns>
    public bool Equals(IFlatIdentifierRepresentation other)
    {
        return EqualityHelper.Equals(this, other);
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// </returns>
    public override int GetHashCode()
    {
        return EqualityHelper.GetHashCode(
            this.UnitExpression.Unit?.GetHashCode() ?? 0,
            FlatPresentationHelper.HatHashCode,
            this.Exponent.GetHashCode());
    }

    /// <summary>
    /// Determines whether the specified <see cref="object" />, is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    public override bool Equals(object obj)
    {
        return EqualityHelper.Equals(this, obj);
    }

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return this.UnitExpression
               + CharacterConverter.ToExponentNotation(this.Exponent.ToString(CultureInfo.CurrentCulture));
    }
}