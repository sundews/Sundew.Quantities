// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeSpanExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using System;
using Sundew.Quantities.Core;
using Sundew.Quantities.UnitSelectors;

/// <summary>
/// Extension methods for converting <see cref="TimeSpan"/> into <see cref="Time"/>.
/// </summary>
public static class TimeSpanExtensions
{
    /// <summary>
    /// Converts the specified <see cref="TimeSpan"/> to <see cref="Time"/> with the specified unit.
    /// </summary>
    /// <param name="timeSpan">The time span.</param>
    /// <param name="unitSelector">The unit selector.</param>
    /// <returns>The <see cref="Time"/> quantity.</returns>
    public static Time ToTime(this TimeSpan timeSpan, SelectUnit<TimeUnitSelector> unitSelector)
    {
        return ((Time)timeSpan).ToUnit(unitSelector);
    }
}