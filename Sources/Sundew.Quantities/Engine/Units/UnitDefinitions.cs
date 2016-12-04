// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitDefinitions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Units
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Contains the unit and prefix definitions.
    /// See: http://www.ebyte.it/library/educards/siunits/TablesOfSiUnitsAndPrefixes.html.
    /// </summary>
    [SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1650:ElementDocumentationMustBeSpelledCorrectly",
        Justification = "Spelling rules does not apply for links.")]
    public static class UnitDefinitions
    {
        /// <summary>The second unit.</summary>
        public static readonly Unit Second = new Unit("s");

        /// <summary>The meter unit.</summary>
        public static readonly Unit Meter = new Unit("m");

        /// <summary>The kelvin unit.</summary>
        public static readonly Unit Kelvin = new Unit("K");

        /// <summary>The ampere unit.</summary>
        public static readonly Unit Ampere = new Unit("A");

        /// <summary>The candela unit.</summary>
        public static readonly Unit Candela = new Unit("cd");

        /// <summary>The kilogram unit.</summary>
        public static readonly PrefixedBaseUnit KiloGram = new PrefixedBaseUnit(Prefixes.Kilo, "g");

        /// <summary>The readian unit.</summary>
        public static readonly Unit Radian = new RadianUnit("rad");

        /// <summary>The steradian unit.</summary>
        public static readonly Unit Steradian = new Unit("sr");

        /// <summary>The minute unit.</summary>
        public static readonly FactoredUnit Minute = new FactoredUnit(60, "min", Second);

        /// <summary>The hour unit.</summary>
        public static readonly FactoredUnit Hour = new FactoredUnit(60 * 60, "h", Second);

        /// <summary>The day unit.</summary>
        public static readonly FactoredUnit Day = new FactoredUnit(24 * 60 * 60, "d", Second);

        /// <summary>The week unit.</summary>
        public static readonly FactoredUnit Week = new FactoredUnit(7 * 24 * 60 * 60, "w", Second);

        /// <summary>The month unit.</summary>
        public static readonly FactoredUnit Month = new FactoredUnit(29.53 * 24 * 60 * 60, "mon", Second);

        /// <summary>The year unit.</summary>
        public static readonly FactoredUnit Year = new FactoredUnit(365.25 * 86400, "y", Second);

        /// <summary>The fahrenheit unit.</summary>
        public static readonly MethodUnit Fahrenheit = new MethodUnit(
            fahrenheit => ((fahrenheit - 32) / 1.8) + 273.15,
            kelvin => ((kelvin - 273.15) * 1.8) + 32,
            "°F",
            Kelvin);

        /// <summary>The celsius unit.</summary>
        public static readonly MethodUnit Celsius = new MethodUnit(
            celsius => celsius + 273.15,
            kelvin => kelvin - 273.15,
            "°C",
            Kelvin);

        /// <summary>The gream unit.</summary>
        public static readonly IUnit Gram = KiloGram.GetPrefixedUnit(Prefix.None);

        /// <summary>The tonne unit.</summary>
        public static readonly FactoredUnit Tonne = new FactoredUnit(1000, "t", KiloGram);

        /// <summary>The ounce unit.</summary>
        public static readonly FactoredUnit Ounce = new FactoredUnit(0.028349523124984257, "oz", KiloGram);

        /// <summary>The international avoir dupois ounce unit.</summary>
        public static readonly FactoredUnit InternationalAvoirdupoisOunce = new FactoredUnit(
            0.0283495231,
            "iaoz",
            KiloGram);

        /// <summary>The international troy ounce unit.</summary>
        public static readonly FactoredUnit InternationalTroyOunce = new FactoredUnit(0.0311034768, "itoz", KiloGram);

        /// <summary>The maria theresa ounce unit.</summary>
        public static readonly FactoredUnit MariaTheresaOunce = new FactoredUnit(0.0280668, "mtoz", KiloGram);

        /// <summary>The spanish ounce unit.</summary>
        public static readonly FactoredUnit SpanishOunce = new FactoredUnit(0.02875, "soz", KiloGram);

        /// <summary>The dutch metric ounce unit.</summary>
        public static readonly FactoredUnit DutchMetricOunce = new FactoredUnit(0.0100, "dmoz", KiloGram);

        /// <summary>The chinese metric ounce unit.</summary>
        public static readonly FactoredUnit ChineseMetricOunce = new FactoredUnit(0.050, "cmoz", KiloGram);

        /// <summary>The mile unit.</summary>
        public static readonly FactoredUnit Mile = new FactoredUnit(1609.344, "mi", Meter);

        /// <summary>The inch unit.</summary>
        public static readonly FactoredUnit Inch = new FactoredUnit(0.0254, "in", Meter);

        /// <summary>The foot unit.</summary>
        public static readonly FactoredUnit Foot = new FactoredUnit(0.3048, "f", Meter);

        /// <summary>The yard unit.</summary>
        public static readonly FactoredUnit Yard = new FactoredUnit(0.9144, "yd", Meter);

        /// <summary>The nautical mile unit.</summary>
        public static readonly FactoredUnit NauticalMile = new FactoredUnit(1.852, "nmi", Meter);

        /// <summary>The liter unit.</summary>
        public static readonly FactoredUnit Liter = new FactoredUnit(0.001, "L", Meter.Exp(3));

        /// <summary>The velocity unit.</summary>
        public static readonly DerivedUnit Velocity = new DerivedUnit(Meter / Second);

        /// <summary>The acceleration unit.</summary>
        public static readonly DerivedUnit Acceleration = new DerivedUnit(Meter / Second.Exp(2));

        /// <summary>The hertz unit.</summary>
        public static readonly DerivedUnit Hertz = new DerivedUnit("Hz", ConstantExpression.One / Second);

        /// <summary>The newton unit.</summary>
        public static readonly DerivedUnit Newton = new DerivedUnit("N", KiloGram * Meter / Second.Exp(2));

        /// <summary>The watt unit.</summary>
        public static readonly DerivedUnit Watt = new DerivedUnit("W", KiloGram * Meter.Exp(2) / Second.Exp(3));

        /// <summary>The joule unit.</summary>
        public static readonly DerivedUnit Joule = new DerivedUnit("J", KiloGram * Meter.Exp(2) / Second.Exp(2));

        /// <summary>The momentum unit.</summary>
        public static readonly DerivedUnit Momentum = new DerivedUnit(KiloGram * Meter / Second);

        /// <summary>The volt unit.</summary>
        public static readonly DerivedUnit Volt = new DerivedUnit(
            "V",
            KiloGram * Meter.Exp(2) / (Ampere * Second.Exp(3)));

        /// <summary>The ohm unit.</summary>
        public static readonly DerivedUnit Ohm = new DerivedUnit(
            "Ω",
            KiloGram * Meter.Exp(2) / (Ampere.Exp(2) * Second.Exp(3)));

        /// <summary>The coulomb unit.</summary>
        public static readonly DerivedUnit Coulomb = new DerivedUnit("C", Ampere * Second);

        /// <summary>The siemens unit.</summary>
        public static readonly DerivedUnit Siemens = new DerivedUnit(
            "S",
            (ConstantExpression.One / KiloGram) * (ConstantExpression.One / Meter.Exp(2)) * Second.Exp(3) * Ampere.Exp(2));

        /// <summary>The farad unit.</summary>
        public static readonly DerivedUnit Farad = new DerivedUnit(
            "F",
            Second.Exp(4) * Ampere.Exp(2) * (ConstantExpression.One / Meter.Exp(2) * ConstantExpression.One / KiloGram));

        /// <summary>The henry unit.</summary>
        public static readonly DerivedUnit Henry = new DerivedUnit(
            "H",
            KiloGram * Meter.Exp(2) / Ampere.Exp(2) * Second.Exp(2));

        /// <summary>The weber unit.</summary>
        public static readonly DerivedUnit Weber = new DerivedUnit(
            "Wb",
            KiloGram * Meter.Exp(2) * (ConstantExpression.One / Ampere) * (ConstantExpression.One / Second.Exp(2)));

        /// <summary>The tesla unit.</summary>
        public static readonly DerivedUnit Tesla = new DerivedUnit(
            "T",
            KiloGram * Second.Exp(2) * ConstantExpression.One / Ampere);

        /// <summary>The pascal unit.</summary>
        public static readonly DerivedUnit Pascal = new DerivedUnit("Pa", Newton / Meter.Exp(2));

        /// <summary>The bar unit.</summary>
        public static readonly FactoredUnit Bar = new FactoredUnit(Math.Pow(10, 5), "bar", Newton / Meter.Exp(2));

        /// <summary>The technical atmosphere unit.</summary>
        public static readonly MethodUnit TechnicalAtmosphere = new MethodUnit(
            at => at * 98066.5,
            pascal => pascal * 0.000010197162129779282,
            "at",
            Newton / Meter.Exp(2));

        /// <summary>The standard atmosphere unit.</summary>
        public static readonly MethodUnit StandardAtmosphere = new MethodUnit(
            atm => atm * 101325.01000002761,
            pascal => pascal * 0.00000986923169314,
            "atm",
            Newton / Meter.Exp(2));

        /// <summary>The torr unit.</summary>
        public static readonly MethodUnit Torr = new MethodUnit(
            torr => torr * 133.32237000002308,
            pascal => pascal * 0.00750061673821,
            "Torr",
            Newton / Meter.Exp(2));

        /// <summary>The psi unit.</summary>
        public static readonly MethodUnit Psi = new MethodUnit(
            psi => psi * 6894.75729,
            pascal => pascal * 0.000145037738007,
            "psi",
            Newton / Meter.Exp(2));

        /// <summary>The degree unit.</summary>
        public static readonly FactoredUnit Degree = new FactoredUnit(Math.PI / 180, "°", Radian);

        /// <summary>The turn unit.</summary>
        public static readonly FactoredUnit Turn = new FactoredUnit(2, "τ", Radian);

        /// <summary>The lumen unit.</summary>
        public static readonly DerivedUnit Lumen = new DerivedUnit("lm", Candela * Steradian);

        /// <summary>The lux unit.</summary>
        public static readonly DerivedUnit Lux = new DerivedUnit("lx", Lumen / Meter.Exp(2));

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>.</returns>
        public static IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return Meter;
            yield return Mile;
            yield return NauticalMile;
            yield return Inch;
            yield return Foot;
            yield return Yard;
            yield return Liter;

            yield return Second;
            yield return Minute;
            yield return Hour;
            yield return Day;
            yield return Week;
            yield return Month;
            yield return Year;

            yield return Kelvin;
            yield return Fahrenheit;
            yield return Celsius;

            yield return Gram;
            yield return Tonne;
            yield return ChineseMetricOunce;
            yield return DutchMetricOunce;
            yield return InternationalAvoirdupoisOunce;
            yield return InternationalTroyOunce;
            yield return MariaTheresaOunce;
            yield return Ounce;
            yield return SpanishOunce;

            yield return Bar;
            yield return TechnicalAtmosphere;
            yield return StandardAtmosphere;
            yield return Torr;
            yield return Psi;

            yield return Ampere;

            yield return Candela;

            yield return Radian;
            yield return Degree;
            yield return Turn;

            yield return Steradian;
        }

        /// <summary>
        /// Gets the default derived unit.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>.</returns>
        public static IEnumerable<DerivedUnit> GetDefaultDerivedUnit()
        {
            yield return Lux;
            yield return Lumen;

            yield return Hertz;

            yield return Joule;
            yield return Newton;
            yield return Pascal;
            yield return Watt;

            yield return Volt;
            yield return Coulomb;
            yield return Farad;
            yield return Henry;
            yield return Ohm;
            yield return Siemens;
            yield return Tesla;
            yield return Weber;
        }

        /// <summary>
        /// Gets the default prefixes.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{Prefix}"/>.</returns>
        public static IEnumerable<Prefix> GetDefaultPrefixes()
        {
            yield return Prefixes.Yotta;
            yield return Prefixes.Zetta;
            yield return Prefixes.Exa;
            yield return Prefixes.Peta;
            yield return Prefixes.Tera;
            yield return Prefixes.Giga;
            yield return Prefixes.Mega;
            yield return Prefixes.Kilo;
            yield return Prefixes.Hecto;
            yield return Prefixes.Deca;
            yield return Prefixes.Deci;
            yield return Prefixes.Centi;
            yield return Prefixes.Milli;
            yield return Prefixes.Micro;
            yield return Prefixes.Nano;
            yield return Prefixes.Pico;
            yield return Prefixes.Femto;
            yield return Prefixes.Atto;
            yield return Prefixes.Zepto;
            yield return Prefixes.Yocto;
        }
    }
}