// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrefixedDistanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Distance"/> unit selector.
    /// </summary>
    public interface IPrefixedDistanceUnitSelector : IPrefixSelector<IDistanceUnitSelector>, IDistanceUnitSelector
    {
    }
}