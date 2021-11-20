﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitConvertible{TQuantity,TUnitSelector}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

/// <summary>
/// Interface for implementing unit conversion methods.
/// </summary>
/// <typeparam name="TQuantity">The type of the value.</typeparam>
/// <typeparam name="TUnitSelector">The type of the unit selector.</typeparam>
public interface IUnitConvertible<out TQuantity, out TUnitSelector> : IUnitConvertible<TQuantity>
{
    /// <summary>
    /// Converts this object to a quantity using the unit specified by the unit selector"/>.
    /// </summary>
    /// <param name="unitSelector">The unit selector.</param>
    /// <returns>The converted quantity.</returns>
    TQuantity ToUnit(SelectUnit<TUnitSelector> unitSelector);

    /// <summary>
    /// Converts this object to a <see cref="double"/> using the unit specified by the unit selector/>.
    /// </summary>
    /// <param name="unitSelector">The unit selector.</param>
    /// <returns>The converted <see cref="double"/>.</returns>
    double ToDouble(SelectUnit<TUnitSelector> unitSelector);
}