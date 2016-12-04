// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Squared.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Represents the squared result of a <see cref="IDeferredQuantity" />.
    /// </summary>
    /// <typeparam name="TBase">The type of the base.</typeparam>
    public class Squared<TBase> : IDeferredQuantity
        where TBase : IDeferredQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Squared{TBase}"/> class.
        /// </summary>
        /// <param name="base">The base quantity.</param>
        public Squared(TBase @base)
        {
            this.Base = @base;
        }

        /// <summary>
        /// Gets the base.
        /// </summary>
        /// <value>
        /// The base quantity.
        /// </value>
        public TBase Base { get; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>
        /// A <see cref="IQuantity{TQuantity}" />.
        /// </returns>
        public IQuantity GetResult()
        {
            return QuantityOperations.Exponential(this.Base.GetResult(), 2);
        }
    }
}