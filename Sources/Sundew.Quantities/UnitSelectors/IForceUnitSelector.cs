// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IForceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Force"/> unit selector.
    /// </summary>
    public interface IForceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Newton.
        /// </summary>
        /// <value>
        /// The Newton.
        /// </value>
        Expression Newtons { get; }
    }
}