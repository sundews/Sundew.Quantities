// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariableFlatIdentifierRepresentation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Conversion
{
    using System;
    using System.Globalization;

    using Sundew.Base.Equality;
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Internals;

    /// <summary>
    /// Flat identifier representation for <see cref="VariableExpression"/>.
    /// </summary>
    public sealed class VariableFlatIdentifierRepresentation : IFlatIdentifierRepresentation,
                                                               IEquatable<VariableFlatIdentifierRepresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableFlatIdentifierRepresentation"/> class.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="exponent">The exponent.</param>
        public VariableFlatIdentifierRepresentation(VariableExpression variableExpression, double exponent)
        {
            this.VariableExpression = variableExpression;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Gets the variable expression.
        /// </summary>
        /// <value>
        /// The variable expression.
        /// </value>
        public VariableExpression VariableExpression { get; }

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
        public bool Equals(VariableFlatIdentifierRepresentation other)
        {
            return EqualityHelper.Equals(
                this,
                other,
                () => this.VariableExpression.Equals(other.VariableExpression) && this.Exponent.Equals(other.Exponent));
        }

        /// <summary>
        /// To the resulting expression.
        /// </summary>
        /// <returns>The resulting <see cref="Expression"/>.</returns>
        public Expression ToResultingExpression()
        {
            return FlatPresentationHelper.CreateResultingExpression(this.VariableExpression, this.Exponent);
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
                this.VariableExpression.VariableName,
                FlatPresentationHelper.HatHashCode,
                this.Exponent);
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
            return this.VariableExpression
                   + CharacterConverter.ToExponentNotation(this.Exponent.ToString(CultureInfo.CurrentCulture));
        }
    }
}