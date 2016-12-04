// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrefixedAccelerationUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Acceleration"/> unit selector.
    /// </summary>
    public interface IPrefixedAccelerationUnitSelector : IAccelerationUnitSelector,
                                                         IPrefixSelector<IAccelerationUnitSelector>
    {
    }
}