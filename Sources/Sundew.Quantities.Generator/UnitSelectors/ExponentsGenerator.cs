// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExponentsGenerator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.UnitSelectors
{
    using Sundew.Text.Generation.Common;

    public static class ExponentsGenerator
    {
        public static IndentedString Generate(QuantityModel modelModel)
        {
            return new IndentedString(8, $@"
/// <summary>
/// Gets the square.
/// </summary>
/// <value>
/// The square.
/// </value>
public {PrefixesGenerator.GetPrefixesAndUnitsInterface(modelModel)} Square => this.GetPrefixesAndUnits(2);

/// <summary>
/// Gets the cubic.
/// </summary>
/// <value>
/// The cubic.
/// </value>
public {PrefixesGenerator.GetPrefixesAndUnitsInterface(modelModel)} Cubic => this.GetPrefixesAndUnits(3);

/// <summary>
/// Gets the quartic.
/// </summary>
/// <value>
/// The quartic.
/// </value>
public {PrefixesGenerator.GetPrefixesAndUnitsInterface(modelModel)} Quartic => this.GetPrefixesAndUnits(4);

/// <summary>
/// Gets the quintic.
/// </summary>
/// <value>
/// The quintic.
/// </value>
public {PrefixesGenerator.GetPrefixesAndUnitsInterface(modelModel)} Quintic => this.GetPrefixesAndUnits(5);
");
        }

        internal static string GetPrefixesAndUnitsInterface(QuantityModel quantityModel)
        {
            return $"IPrefixSelector<I{quantityModel.Name}UnitSelector>";
        }
    }
}