﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitDefinitions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Units;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Contains the unit and prefix definitions.
/// See: http://www.ebyte.it/library/educards/siunits/TablesOfSiUnitsAndPrefixes.html.
/// </summary>
public static class UnitDefinitions
{
    /// <summary>The second unit.</summary>
    public static readonly Unit Second = new("s");

    /// <summary>The meter unit.</summary>
    public static readonly Unit Meter = new("m");

    /// <summary>The kelvin unit.</summary>
    public static readonly Unit Kelvin = new("K");

    /// <summary>The ampere unit.</summary>
    public static readonly Unit Ampere = new("A");

    /// <summary>The candela unit.</summary>
    public static readonly Unit Candela = new("cd");

    /// <summary>The kilogram unit.</summary>
    public static readonly PrefixedBaseUnit KiloGram = new(Representations.Units.Prefixes.Kilo, "g");

    /// <summary>The readian unit.</summary>
    public static readonly Unit Radian = new RadianUnit("rad");

    /// <summary>The steradian unit.</summary>
    public static readonly Unit Steradian = new("sr");

    /// <summary>The minute unit.</summary>
    public static readonly FactoredUnit Minute = new(60, "min", Second);

    /// <summary>The hour unit.</summary>
    public static readonly FactoredUnit Hour = new(60 * 60, "h", Second);

    /// <summary>The day unit.</summary>
    public static readonly FactoredUnit Day = new(24 * 60 * 60, "d", Second);

    /// <summary>The week unit.</summary>
    public static readonly FactoredUnit Week = new(7 * 24 * 60 * 60, "w", Second);

    /// <summary>The month unit.</summary>
    public static readonly FactoredUnit Month = new(29.53 * 24 * 60 * 60, "mon", Second);

    /// <summary>The year unit.</summary>
    public static readonly FactoredUnit Year = new(365.25 * 86400, "y", Second);

    /// <summary>The fahrenheit unit.</summary>
    public static readonly MethodUnit Fahrenheit = new(
        fahrenheit => ((fahrenheit - 32) / 1.8) + 273.15,
        kelvin => ((kelvin - 273.15) * 1.8) + 32,
        "°F",
        Kelvin);

    /// <summary>The celsius unit.</summary>
    public static readonly MethodUnit Celsius = new(
        celsius => celsius + 273.15,
        kelvin => kelvin - 273.15,
        "°C",
        Kelvin);

    /// <summary>The gream unit.</summary>
    public static readonly IUnit Gram = KiloGram.GetPrefixedUnit(Prefix.None);

    /// <summary>The tonne unit.</summary>
    public static readonly FactoredUnit Tonne = new(1000, "t", KiloGram);

    /// <summary>The ounce unit.</summary>
    public static readonly FactoredUnit Ounce = new(0.028349523124984257, "oz", KiloGram);

    /// <summary>The international avoir dupois ounce unit.</summary>
    public static readonly FactoredUnit InternationalAvoirdupoisOunce = new(
        0.0283495231,
        "iaoz",
        KiloGram);

    /// <summary>The international troy ounce unit.</summary>
    public static readonly FactoredUnit InternationalTroyOunce = new(0.0311034768, "itoz", KiloGram);

    /// <summary>The maria theresa ounce unit.</summary>
    public static readonly FactoredUnit MariaTheresaOunce = new(0.0280668, "mtoz", KiloGram);

    /// <summary>The spanish ounce unit.</summary>
    public static readonly FactoredUnit SpanishOunce = new(0.02875, "soz", KiloGram);

    /// <summary>The dutch metric ounce unit.</summary>
    public static readonly FactoredUnit DutchMetricOunce = new(0.0100, "dmoz", KiloGram);

    /// <summary>The chinese metric ounce unit.</summary>
    public static readonly FactoredUnit ChineseMetricOunce = new(0.050, "cmoz", KiloGram);

    /// <summary>The mile unit.</summary>
    public static readonly FactoredUnit Mile = new(1609.344, "mi", Meter);

    /// <summary>The inch unit.</summary>
    public static readonly FactoredUnit Inch = new(0.0254, "in", Meter);

    /// <summary>The foot unit.</summary>
    public static readonly FactoredUnit Foot = new(0.3048, "f", Meter);

    /// <summary>The yard unit.</summary>
    public static readonly FactoredUnit Yard = new(0.9144, "yd", Meter);

    /// <summary>The nautical mile unit.</summary>
    public static readonly FactoredUnit NauticalMile = new(1.852, "nmi", Meter);

    /// <summary>The liter unit.</summary>
    public static readonly FactoredUnit Liter = new(0.001, "L", Meter.Exp(3));

    /// <summary>The velocity unit.</summary>
    public static readonly DerivedUnit Velocity = new(Meter / Second);

    /// <summary>The acceleration unit.</summary>
    public static readonly DerivedUnit Acceleration = new(Meter / Second.Exp(2));

    /// <summary>The hertz unit.</summary>
    public static readonly DerivedUnit Hertz = new("Hz", ConstantExpression.One / Second);

    /// <summary>The newton unit.</summary>
    public static readonly DerivedUnit Newton = new("N", KiloGram * Meter / Second.Exp(2));

    /// <summary>The watt unit.</summary>
    public static readonly DerivedUnit Watt = new("W", KiloGram * Meter.Exp(2) / Second.Exp(3));

    /// <summary>The joule unit.</summary>
    public static readonly DerivedUnit Joule = new("J", KiloGram * Meter.Exp(2) / Second.Exp(2));

    /// <summary>The momentum unit.</summary>
    public static readonly DerivedUnit Momentum = new(KiloGram * Meter / Second);

    /// <summary>The volt unit.</summary>
    public static readonly DerivedUnit Volt = new(
        "V",
        KiloGram * Meter.Exp(2) / (Ampere * Second.Exp(3)));

    /// <summary>The ohm unit.</summary>
    public static readonly DerivedUnit Ohm = new(
        "Ω",
        KiloGram * Meter.Exp(2) / (Ampere.Exp(2) * Second.Exp(3)));

    /// <summary>The coulomb unit.</summary>
    public static readonly DerivedUnit Coulomb = new("C", Ampere * Second);

    /// <summary>The siemens unit.</summary>
    public static readonly DerivedUnit Siemens = new(
        "S",
        (ConstantExpression.One / KiloGram) * (ConstantExpression.One / Meter.Exp(2)) * Second.Exp(3) * Ampere.Exp(2));

    /// <summary>The farad unit.</summary>
    public static readonly DerivedUnit Farad = new(
        "F",
        Second.Exp(4) * Ampere.Exp(2) * (ConstantExpression.One / Meter.Exp(2) * ConstantExpression.One / KiloGram));

    /// <summary>The henry unit.</summary>
    public static readonly DerivedUnit Henry = new(
        "H",
        KiloGram * Meter.Exp(2) / Ampere.Exp(2) * Second.Exp(2));

    /// <summary>The weber unit.</summary>
    public static readonly DerivedUnit Weber = new(
        "Wb",
        KiloGram * Meter.Exp(2) * (ConstantExpression.One / Ampere) * (ConstantExpression.One / Second.Exp(2)));

    /// <summary>The tesla unit.</summary>
    public static readonly DerivedUnit Tesla = new(
        "T",
        KiloGram * Second.Exp(2) * ConstantExpression.One / Ampere);

    /// <summary>The pascal unit.</summary>
    public static readonly DerivedUnit Pascal = new("Pa", Newton / Meter.Exp(2));

    /// <summary>The bar unit.</summary>
    public static readonly FactoredUnit Bar = new(Math.Pow(10, 5), "bar", Newton / Meter.Exp(2));

    /// <summary>The technical atmosphere unit.</summary>
    public static readonly MethodUnit TechnicalAtmosphere = new(
        at => at * 98066.5,
        pascal => pascal * 0.000010197162129779282,
        "at",
        Newton / Meter.Exp(2));

    /// <summary>The standard atmosphere unit.</summary>
    public static readonly MethodUnit StandardAtmosphere = new(
        atm => atm * 101325.01000002761,
        pascal => pascal * 0.00000986923169314,
        "atm",
        Newton / Meter.Exp(2));

    /// <summary>The torr unit.</summary>
    public static readonly MethodUnit Torr = new(
        torr => torr * 133.32237000002308,
        pascal => pascal * 0.00750061673821,
        "Torr",
        Newton / Meter.Exp(2));

    /// <summary>The psi unit.</summary>
    public static readonly MethodUnit Psi = new(
        psi => psi * 6894.75729,
        pascal => pascal * 0.000145037738007,
        "psi",
        Newton / Meter.Exp(2));

    /// <summary>The degree unit.</summary>
    public static readonly FactoredUnit Degree = new(Math.PI / 180, "°", Radian);

    /// <summary>The turn unit.</summary>
    public static readonly FactoredUnit Turn = new(2, "τ", Radian);

    /// <summary>The lumen unit.</summary>
    public static readonly DerivedUnit Lumen = new("lm", Candela * Steradian);

    /// <summary>The lux unit.</summary>
    public static readonly DerivedUnit Lux = new("lx", Lumen / Meter.Exp(2));

    private static readonly IUnit[] Units =
    {
        Meter, Mile,
        NauticalMile,
        Inch,
        Foot,
        Yard,
        Liter,

        Second,
        Minute,
        Hour,
        Day,
        Week,
        Month,
        Year,

        Kelvin,
        Fahrenheit,
        Celsius,

        Gram,
        Tonne,
        ChineseMetricOunce,
        DutchMetricOunce,
        InternationalAvoirdupoisOunce,
        InternationalTroyOunce,
        MariaTheresaOunce,
        Ounce,
        SpanishOunce,

        Bar,
        TechnicalAtmosphere,
        StandardAtmosphere,
        Torr,
        Psi,

        Ampere,

        Candela,

        Radian,
        Degree,
        Turn,

        Steradian
    };

    private static readonly DerivedUnit[] DerivedUnits =
    {
        Lux,
        Lumen,

        Hertz,

        Joule,
        Newton,
        Pascal,
        Watt,

        Volt,
        Coulomb,
        Farad,
        Henry,
        Ohm,
        Siemens,
        Tesla,
        Weber
    };

    private static readonly Prefix[] Prefixes =
    {
        Representations.Units.Prefixes.Yotta,
        Representations.Units.Prefixes.Zetta,
        Representations.Units.Prefixes.Exa,
        Representations.Units.Prefixes.Peta,
        Representations.Units.Prefixes.Tera,
        Representations.Units.Prefixes.Giga,
        Representations.Units.Prefixes.Mega,
        Representations.Units.Prefixes.Kilo,
        Representations.Units.Prefixes.Hecto,
        Representations.Units.Prefixes.Deca,
        Representations.Units.Prefixes.Deci,
        Representations.Units.Prefixes.Centi,
        Representations.Units.Prefixes.Milli,
        Representations.Units.Prefixes.Micro,
        Representations.Units.Prefixes.Nano,
        Representations.Units.Prefixes.Pico,
        Representations.Units.Prefixes.Femto,
        Representations.Units.Prefixes.Atto,
        Representations.Units.Prefixes.Zepto,
        Representations.Units.Prefixes.Yocto
    };

    /// <summary>
    /// Gets the default units.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IUnit}"/>.</returns>
    public static IEnumerable<IUnit> GetDefaultUnits()
    {
        return Units;
    }

    /// <summary>
    /// Gets the default derived unit.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IUnit}"/>.</returns>
    public static IEnumerable<DerivedUnit> GetDefaultDerivedUnit()
    {
        return DerivedUnits;
    }

    /// <summary>
    /// Gets the default prefixes.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{Prefix}"/>.</returns>
    public static IEnumerable<Prefix> GetDefaultPrefixes()
    {
        return Prefixes;
    }
}