// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantity{TQuantity}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Interface for implementing strongly typed quantities.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public interface IQuantity<out TQuantity> : IQuantity
    {
        /// <summary>
        /// Creates the quantity.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>A quantity.</returns>
        TQuantity CreateQuantity(double value, IUnit unit);
    }
}