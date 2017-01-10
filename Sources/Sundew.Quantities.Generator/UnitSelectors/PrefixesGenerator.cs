// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrefixesGenerator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.UnitSelectors
{
    using Sundew.Text.Generation.Common;

    public static class PrefixesGenerator
    {
        public static IndentedString Generate(QuantityModel quantityModel)
        {
            return new IndentedString(8, $@"
/// <summary>
/// Gets the yotta.
/// </summary>
/// <value>
/// The yotta.
/// </value>
public {GetUnitsInterface(quantityModel)} Yotta => this.GetUnits(Prefixes.Yotta);

/// <summary>
/// Gets the zetta.
/// </summary>
/// <value>
/// The zetta.
/// </value>
public {GetUnitsInterface(quantityModel)} Zetta => this.GetUnits(Prefixes.Zetta);

/// <summary>
/// Gets the exa.
/// </summary>
/// <value>
/// The exa.
/// </value>
public {GetUnitsInterface(quantityModel)} Exa => this.GetUnits(Prefixes.Exa);

/// <summary>
/// Gets the peta.
/// </summary>
/// <value>
/// The peta.
/// </value>
public {GetUnitsInterface(quantityModel)} Peta => this.GetUnits(Prefixes.Peta);

/// <summary>
/// Gets the tera.
/// </summary>
/// <value>
/// The tera.
/// </value>
public {GetUnitsInterface(quantityModel)} Tera => this.GetUnits(Prefixes.Tera);

/// <summary>
/// Gets the giga.
/// </summary>
/// <value>
/// The giga.
/// </value>
public {GetUnitsInterface(quantityModel)} Giga => this.GetUnits(Prefixes.Giga);

/// <summary>
/// Gets the mega.
/// </summary>
/// <value>
/// The mega.
/// </value>
public {GetUnitsInterface(quantityModel)} Mega => this.GetUnits(Prefixes.Mega);

/// <summary>
/// Gets the kilo.
/// </summary>
/// <value>
/// The kilo.
/// </value>
public {GetUnitsInterface(quantityModel)} Kilo => this.GetUnits(Prefixes.Kilo);

/// <summary>
/// Gets the hecto.
/// </summary>
/// <value>
/// The hecto.
/// </value>
public {GetUnitsInterface(quantityModel)} Hecto => this.GetUnits(Prefixes.Hecto);

/// <summary>
/// Gets the deca.
/// </summary>
/// <value>
/// The deca.
/// </value>
public {GetUnitsInterface(quantityModel)} Deca => this.GetUnits(Prefixes.Deca);

/// <summary>
/// Gets the deci.
/// </summary>
/// <value>
/// The deci.
/// </value>
public {GetUnitsInterface(quantityModel)} Deci => this.GetUnits(Prefixes.Deci);

/// <summary>
/// Gets the centi.
/// </summary>
/// <value>
/// The centi.
/// </value>
public {GetUnitsInterface(quantityModel)} Centi => this.GetUnits(Prefixes.Centi);

/// <summary>
/// Gets the milli.
/// </summary>
/// <value>
/// The milli.
/// </value>
public {GetUnitsInterface(quantityModel)} Milli => this.GetUnits(Prefixes.Milli);

/// <summary>
/// Gets the micro.
/// </summary>
/// <value>
/// The micro.
/// </value>
public {GetUnitsInterface(quantityModel)} Micro => this.GetUnits(Prefixes.Micro);

/// <summary>
/// Gets the nano.
/// </summary>
/// <value>
/// The nano.
/// </value>
public {GetUnitsInterface(quantityModel)} Nano => this.GetUnits(Prefixes.Nano);

/// <summary>
/// Gets the pico.
/// </summary>
/// <value>
/// The pico.
/// </value>
public {GetUnitsInterface(quantityModel)} Pico => this.GetUnits(Prefixes.Pico);

/// <summary>
/// Gets the femto.
/// </summary>
/// <value>
/// The femto.
/// </value>
public {GetUnitsInterface(quantityModel)} Femto => this.GetUnits(Prefixes.Femto);

/// <summary>
/// Gets the atto.
/// </summary>
/// <value>
/// The atto.
/// </value>
public {GetUnitsInterface(quantityModel)} Atto => this.GetUnits(Prefixes.Atto);

/// <summary>
/// Gets the zepto.
/// </summary>
/// <value>
/// The zepto.
/// </value>
public {GetUnitsInterface(quantityModel)} Zepto => this.GetUnits(Prefixes.Zepto);

/// <summary>
/// Gets the yocto.
/// </summary>
/// <value>
/// The yocto.
/// </value>
public {GetUnitsInterface(quantityModel)} Yocto => this.GetUnits(Prefixes.Yocto);
");
        }

        internal static string GetUnitsInterface(QuantityModel quantityModel)
        {
            return $"I{quantityModel.Name}UnitSelector";
        }

        internal static string GetPrefixesAndUnitsInterface(QuantityModel quantityModel)
        {
            return $"IPrefixed{quantityModel.Name}UnitSelector";
        }
    }
}