// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantity{TQuantity,TUnitSelector}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Interface for implementing a quantity with an unit selector.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    /// <typeparam name="TUnitSelector">The type of the unit selector.</typeparam>
    /// <seealso cref="Sundew.Quantities.Engine.Quantities.IQuantity{TQuantity}" />
    /// <seealso cref="Sundew.Quantities.Engine.Quantities.IUnitConvertible{TQuantity, TUnitSelector}" />
    public interface IQuantity<out TQuantity, out TUnitSelector> : IQuantity<TQuantity>, IUnitConvertible<TQuantity, TUnitSelector>
        where TQuantity : IQuantity
    {
        /// <summary>
        /// Creates the unit selector.
        /// </summary>
        /// <returns>A unit selector.</returns>
        TUnitSelector CreateUnitSelector();
    }
}