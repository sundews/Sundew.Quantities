// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassUnits.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Units;

using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Units;

/// <summary>
/// Mass units.
/// </summary>
public class MassUnits
{
    /// <summary>
    /// Gets the base unit.
    /// </summary>
    /// <value>
    /// The base unit.
    /// </value>
    public IUnit BaseUnit => this.KiloGrams;

    /// <summary>
    /// Gets the gram.
    /// </summary>
    /// <value>
    /// The gram.
    /// </value>
    public IUnit Grams => UnitDefinitions.Gram;

    /// <summary>
    /// Gets the kilo gram.
    /// </summary>
    /// <value>
    /// The kilo gram.
    /// </value>
    public IUnit KiloGrams => UnitDefinitions.KiloGram;

    /// <summary>
    /// Gets the tonne.
    /// </summary>
    /// <value>
    /// The tonne.
    /// </value>
    public IUnit Tonnes => UnitDefinitions.Tonne;

    /// <summary>
    /// Gets the chinese metric ounce.
    /// </summary>
    /// <value>
    /// The chinese metric ounce.
    /// </value>
    public IUnit ChineseMetricOunces => UnitDefinitions.ChineseMetricOunce;

    /// <summary>
    /// Gets the dutch metric ounce.
    /// </summary>
    /// <value>
    /// The dutch metric ounce.
    /// </value>
    public IUnit DutchMetricOunces => UnitDefinitions.DutchMetricOunce;

    /// <summary>
    /// Gets the international avoirdupois ounce.
    /// </summary>
    /// <value>
    /// The international avoirdupois ounce.
    /// </value>
    public IUnit InternationalAvoirdupoisOunces => UnitDefinitions.InternationalAvoirdupoisOunce;

    /// <summary>
    /// Gets the international troy ounce.
    /// </summary>
    /// <value>
    /// The international troy ounce.
    /// </value>
    public IUnit InternationalTroyOunces => UnitDefinitions.InternationalTroyOunce;

    /// <summary>
    /// Gets the maria theresa ounce.
    /// </summary>
    /// <value>
    /// The maria theresa ounce.
    /// </value>
    public IUnit MariaTheresaOunces => UnitDefinitions.MariaTheresaOunce;

    /// <summary>
    /// Gets the ounce.
    /// </summary>
    /// <value>
    /// The ounce.
    /// </value>
    public IUnit Ounces => UnitDefinitions.Ounce;

    /// <summary>
    /// Gets the spanish ounce.
    /// </summary>
    /// <value>
    /// The spanish ounce.
    /// </value>
    public IUnit SpanishOunces => UnitDefinitions.SpanishOunce;
}