// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExponentSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelection;

/// <summary>
/// Interface for implementing an order of magnitude selector.
/// </summary>
/// <typeparam name="TUnitSelector">The type of the derived units.</typeparam>
public interface IExponentSelector<out TUnitSelector>
{
    /// <summary>
    /// Gets the square.
    /// </summary>
    /// <value>
    /// The square.
    /// </value>
    TUnitSelector Square { get; }

    /// <summary>
    /// Gets the cubic.
    /// </summary>
    /// <value>
    /// The cubic.
    /// </value>
    TUnitSelector Cubic { get; }

    /// <summary>
    /// Gets the quartic.
    /// </summary>
    /// <value>
    /// The quartic.
    /// </value>
    TUnitSelector Quartic { get; }

    /// <summary>
    /// Gets the quintic.
    /// </summary>
    /// <value>
    /// The quintic.
    /// </value>
    TUnitSelector Quintic { get; }
}