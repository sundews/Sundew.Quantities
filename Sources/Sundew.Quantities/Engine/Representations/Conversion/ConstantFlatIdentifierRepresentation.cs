// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstantFlatIdentifierRepresentation.cs" company="Hukano">
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

    /// <summary>
    /// Flat representation of a constant value.
    /// </summary>
    public sealed class ConstantFlatIdentifierRepresentation : IFlatIdentifierRepresentation,
                                                               IEquatable<ConstantFlatIdentifierRepresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantFlatIdentifierRepresentation"/> class.
        /// </summary>
        /// <param name="constant">The constant.</param>
        public ConstantFlatIdentifierRepresentation(double constant)
        {
            this.Constant = constant;
        }

        /// <summary>
        /// Gets the constant.
        /// </summary>
        /// <value>
        /// The constant.
        /// </value>
        public double Constant { get; }

        /// <summary>
        /// Determines whether the specified <see cref="ConstantFlatIdentifierRepresentation" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="ConstantFlatIdentifierRepresentation" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="ConstantFlatIdentifierRepresentation" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(ConstantFlatIdentifierRepresentation other)
        {
            return EqualityHelper.Equals(this, other, () => this.Constant.Equals(other.Constant));
        }

        /// <summary>
        /// Converts this instance to the resulting expression.
        /// </summary>
        /// <returns>
        /// A <see cref="Expression" />.
        /// </returns>
        public Expression ToResultingExpression()
        {
            return new ConstantExpression(this.Constant);
        }

        /// <summary>
        /// Determines whether the specified <see cref="IFlatIdentifierRepresentation" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="IFlatIdentifierRepresentation" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="IFlatIdentifierRepresentation" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
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
            return EqualityHelper.GetHashCode(this.Constant);
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
            return this.Constant.ToString(CultureInfo.CurrentCulture);
        }
    }
}