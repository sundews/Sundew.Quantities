// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrefixedVolumeSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for implementing prefixed volume selector.
    /// </summary>
    public interface IPrefixedVolumeSelector : IVolumeUnitSelector, IPrefixSelector<IVolumeUnitSelector>
    {
    }
}