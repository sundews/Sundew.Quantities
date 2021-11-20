// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExponentsHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.UnitSelectors;

using Sundew.Generator.Core;

public static class ExponentsHelper
{
    public static IndentedString GetExponents(IQuantityModel modelModel)
    {
        return new IndentedString(8, $@"
/// <summary>
/// Gets the square.
/// </summary>
/// <value>
/// The square.
/// </value>
public {PrefixesHelper.GetPrefixesAndUnitsInterface(modelModel)} Square => this.GetPrefixesAndUnits(2);

/// <summary>
/// Gets the cubic.
/// </summary>
/// <value>
/// The cubic.
/// </value>
public {PrefixesHelper.GetPrefixesAndUnitsInterface(modelModel)} Cubic => this.GetPrefixesAndUnits(3);

/// <summary>
/// Gets the quartic.
/// </summary>
/// <value>
/// The quartic.
/// </value>
public {PrefixesHelper.GetPrefixesAndUnitsInterface(modelModel)} Quartic => this.GetPrefixesAndUnits(4);

/// <summary>
/// Gets the quintic.
/// </summary>
/// <value>
/// The quintic.
/// </value>
public {PrefixesHelper.GetPrefixesAndUnitsInterface(modelModel)} Quintic => this.GetPrefixesAndUnits(5);
");
    }

    internal static string GetPrefixesAndUnitsInterface(QuantityModel quantityModel)
    {
        return $"IPrefixSelector<I{quantityModel.Name}UnitSelector>";
    }
}