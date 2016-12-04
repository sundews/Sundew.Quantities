// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnit.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Hierarchical.Units
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing base units.
    /// </summary>
    public interface IUnit : IConvertToAndFromBase, IEquatable<IUnit>
    {
        /// <summary>
        /// Gets the prefix factor.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        double PrefixFactor { get; }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>
        /// The notation.
        /// </value>
        string Notation { get; }

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        IUnit BaseUnit { get; }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        /// <returns>The <see cref="Expression"/> for this unit.</returns>
        Expression GetExpression();

        /// <summary>
        /// Gets the prefixed unit.
        /// </summary>
        /// <param name="newPrefix">The prefix.</param>
        /// <returns>A new <see cref="IUnit"/> with the specified <see cref="Prefix"/>.</returns>
        IUnit GetPrefixedUnit(Prefix newPrefix);

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// The base notation.
        /// </returns>
        string GetNotation(IFormatProvider formatProvider = null);

        /// <summary>
        /// Gets the notation without prefix.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// The notation without a prefix.
        /// </returns>
        string GetNotationWithoutPrefix(IFormatProvider formatProvider = null);

        /// <summary>
        /// Formats the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// The value formatted as a string.
        /// </returns>
        string FormatValue(double value, string format, IFormatProvider formatProvider);
    }
}