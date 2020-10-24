// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelection
{
    using System.Collections.Generic;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Interface for implementing a unit selector.
    /// </summary>
    public interface IUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        Expression BaseUnit { get; }

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{IUnit}" />.
        /// </returns>
        IEnumerable<IUnit> GetDefaultUnits();
    }
}