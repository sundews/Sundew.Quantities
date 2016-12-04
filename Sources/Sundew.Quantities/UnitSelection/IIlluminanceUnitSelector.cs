// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIlluminanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Illuminance"/> unit selector.
    /// </summary>
    public interface IIlluminanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the lux.
        /// </summary>
        /// <value>
        /// The lux <see cref="Expression"/>.
        /// </value>
        Expression Lux { get; }
    }
}