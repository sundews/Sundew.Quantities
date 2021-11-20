// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DistanceUnits.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Units;

using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Units;

/// <summary>
/// Distance units.
/// </summary>
public class DistanceUnits
{
    /// <summary>
    /// Gets the base unit.
    /// </summary>
    /// <value>
    /// The base unit.
    /// </value>
    public IUnit BaseUnit => this.Meters;

    /// <summary>
    /// Gets the meter.
    /// </summary>
    /// <value>
    /// The meter.
    /// </value>
    public IUnit Meters => UnitDefinitions.Meter;

    /// <summary>
    /// Gets the mile.
    /// </summary>
    /// <value>
    /// The mile.
    /// </value>
    public IUnit Miles => UnitDefinitions.Mile;

    /// <summary>
    /// Gets the foot.
    /// </summary>
    /// <value>
    /// The foot.
    /// </value>
    public IUnit Feet => UnitDefinitions.Foot;

    /// <summary>
    /// Gets the inch.
    /// </summary>
    /// <value>
    /// The inch.
    /// </value>
    public IUnit Inches => UnitDefinitions.Inch;

    /// <summary>
    /// Gets the nautical mile.
    /// </summary>
    /// <value>
    /// The nautical mile.
    /// </value>
    public IUnit NauticalMiles => UnitDefinitions.NauticalMile;

    /// <summary>
    /// Gets the yard.
    /// </summary>
    /// <value>
    /// The yard.
    /// </value>
    public IUnit Yards => UnitDefinitions.Yard;
}