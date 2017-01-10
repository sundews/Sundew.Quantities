// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorsGenerator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.Quantities
{
    using Sundew.Text.Generation.Common;

    public class ConstructorsGenerator
    {
        public static IndentedString GetConstructors(QuantityModel quantityModel)
        {
            return new IndentedString(8, $@"
/// <summary>
/// Initializes a new instance of the <see cref=""{quantityModel.Name}""/> struct.
/// </summary>
/// <param name=""value"">The value.</param>
/// <param name=""unitSelector"">The unit selector.</param>
public {quantityModel.Name}(double value, SelectUnit<{quantityModel.Name}UnitSelector> unitSelector)
    : this(value,  UnitBuilder.BuildUnit(unitSelector(new {quantityModel.Name}UnitSelector())))
{{
}}

/// <summary>
/// Initializes a new instance of the <see cref=""{quantityModel.Name}""/> struct.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
public {quantityModel.Name}(IQuantity quantity)
    : this(quantity.Value, quantity.Unit)
{{
}}

/// <summary>
/// Initializes a new instance of the <see cref=""{quantityModel.Name}""/> struct.
/// </summary>
/// <param name=""value"">The value.</param>
public {quantityModel.Name}(double value)
    : this(value, units => units.BaseUnit)
{{
}}

/// <summary>
/// Initializes a new instance of the <see cref=""{quantityModel.Name}""/> struct.
/// </summary>
/// <param name=""value"">The value.</param>
/// <param name=""unit"">The unit.</param>
public {quantityModel.Name}(double value, IUnit unit)
{{
    this.value = value;
    this.Unit = unit;
}}
");
        }
    }
}