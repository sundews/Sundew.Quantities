// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrefixedVelocityUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Velocity"/> unit selector.
    /// </summary>
    public interface IPrefixedVelocityUnitSelector : IVelocityUnitSelector, IPrefixSelector<IVelocityUnitSelector>
    {
    }
}