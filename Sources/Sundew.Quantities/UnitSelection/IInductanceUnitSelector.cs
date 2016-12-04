// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInductanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Inductance"/> unit selector.
    /// </summary>
    public interface IInductanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Henry.
        /// </summary>
        /// <value>
        /// The Henry.
        /// </value>
        Expression Henry { get; }
    }
}