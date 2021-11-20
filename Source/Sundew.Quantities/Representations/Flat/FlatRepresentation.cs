// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatRepresentation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Flat
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Sundew.Base.Equality;
    using Sundew.Quantities.Representations.Internals;

    /// <summary>
    /// Flat representation of a unit.
    /// </summary>
    public sealed class FlatRepresentation : IEnumerable<IFlatIdentifierRepresentation>, IEquatable<FlatRepresentation>
    {
        private readonly Dictionary<string, IFlatIdentifierRepresentation> flatIdentifierRepresentations;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlatRepresentation"/> class.
        /// </summary>
        /// <param name="flatIdentifierRepresentations">The flat identifier representations.</param>
        public FlatRepresentation(Dictionary<string, IFlatIdentifierRepresentation> flatIdentifierRepresentations)
        {
            this.flatIdentifierRepresentations = flatIdentifierRepresentations;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count => this.flatIdentifierRepresentations.Count;

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>An <see cref="IEnumerator{IFlatIdentifierRepresentation}"/>.</returns>
        public IEnumerator<IFlatIdentifierRepresentation> GetEnumerator()
        {
            return
                this.flatIdentifierRepresentations.Select(
                    unitFlatIdentifierRepresentation => unitFlatIdentifierRepresentation.Value).GetEnumerator();
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>An <see cref="IEnumerator{IFlatIdentifierRepresentation}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="FlatRepresentation" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(FlatRepresentation other)
        {
            if (this.Count != other.Count)
            {
                return false;
            }

            var otherFlatIdentifierRepresentation = other.flatIdentifierRepresentations;
            foreach (var otherPair in otherFlatIdentifierRepresentation)
            {
                if (!this.flatIdentifierRepresentations.TryGetValue(otherPair.Key, out var flatIdentifierRepresentation))
                {
                    return false;
                }

                if (!flatIdentifierRepresentation.Equals(otherPair.Value))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Gets the consumer.
        /// </summary>
        /// <returns>A new <see cref="FlatRepresentationConsumer"/>.</returns>
        public FlatRepresentationConsumer GetConsumer()
        {
            return new FlatRepresentationConsumer(this.flatIdentifierRepresentations);
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
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return this.flatIdentifierRepresentations.Aggregate(
                0,
                (current, pair) => EqualityHelper.GetUnorderedHashCode(current, pair.Value.GetHashCode()));
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var flatIdentifierRepresentation in this)
            {
                stringBuilder.Append(flatIdentifierRepresentation);
                stringBuilder.Append(Constants.Multiply);
            }

            return stringBuilder.ToString(0, stringBuilder.Length - 1);
        }
    }
}