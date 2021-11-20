// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prefix.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions;

using System;

/// <summary>
/// Abstract prefix class.
/// </summary>
public abstract class Prefix : IEquatable<Prefix>
{
    /// <summary>
    /// Gets the none prefix.
    /// </summary>
    /// <value>
    /// The none prefix.
    /// </value>
    public static Prefix None { get; } = new FactorOnePrefix();

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public abstract string Name { get; }

    /// <summary>
    /// Gets the factor.
    /// </summary>
    /// <value>
    /// The factor.
    /// </value>
    public abstract double Factor { get; }

    /// <summary>
    /// Gets the notation.
    /// </summary>
    /// <value>
    /// The notation.
    /// </value>
    public abstract string Notation { get; }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
    /// </returns>
    public bool Equals(Prefix other)
    {
        return this.Factor.Equals(other.Factor);
    }

    /// <summary>
    /// Gets the prefixed notation.
    /// </summary>
    /// <param name="unitNotation">The notation.</param>
    /// <returns>The prefixed notation.</returns>
    public abstract string GetPrefixedNotation(string unitNotation);

    /// <summary>
    /// Converts the specified value into the unit's base value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>
    /// The base value.
    /// </returns>
    public abstract double ToBase(double value);

    /// <summary>
    /// Converts the specified base value into the unit's value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The unit's value.</returns>
    public abstract double FromBase(double value);

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

    private class FactorOnePrefix : Prefix
    {
        private const string NoneName = "None";

        public override string Name => NoneName;

        public override double Factor => 1;

        public override string Notation => string.Empty;

        public override string GetPrefixedNotation(string unitNotation)
        {
            return unitNotation;
        }

        public override double FromBase(double value)
        {
            return value;
        }

        public override double ToBase(double value)
        {
            return value;
        }
    }
}