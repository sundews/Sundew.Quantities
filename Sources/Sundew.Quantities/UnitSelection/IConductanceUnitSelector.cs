// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConductanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Conductance"/> unit selector.
    /// </summary>
    public interface IConductanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the siemens.
        /// </summary>
        /// <value>
        /// The siemens.
        /// </value>
        Expression Siemens { get; }
    }
}