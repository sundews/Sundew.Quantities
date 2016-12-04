// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVolumeUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Unit selector for volume.
    /// </summary>
    public interface IVolumeUnitSelector : IDistanceUnitSelector
    {
        /// <summary>
        /// Gets the liter.
        /// </summary>
        /// <value>The liter <see cref="Expression"/>.</value>
        Expression Liters { get; }
    }
}