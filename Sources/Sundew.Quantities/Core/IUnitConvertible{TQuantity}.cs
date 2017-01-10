// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitConvertible{TQuantity}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Interface for implementing unit conversion methods.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public interface IUnitConvertible<out TQuantity> : IUnitConvertible
    {
        /// <summary>
        /// Converts this object to a quantity using the specified unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>The converted quantity.</returns>
        TQuantity ToUnit(IUnit unit);
    }
}