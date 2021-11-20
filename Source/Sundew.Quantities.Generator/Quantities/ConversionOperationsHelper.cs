// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversionOperationsHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.Quantities;

using Sundew.Generator.Core;

public static class ConversionOperationsHelper
{
    public static IndentedString GetConversionOperations(IQuantityModel quantityModel)
    {
        return new IndentedString(8, $@"
/// <summary>
/// Converts this object to a <see cref=""double"" /> using the specified unit.
/// </summary>
/// <param name=""unit"">The quantity unit.</param>
/// <returns>
/// The converted <see cref=""double"" />.
/// </returns>
public double ToDouble(IUnit unit)
{{
    return QuantityOperations.ConvertToUnit(this, unit);
}}

/// <summary>
/// Converts this object to a <see cref=""IQuantity"" /> using the unit specified by the <see cref=""IUnit"" />.
/// </summary>
/// <param name=""unit"">The target unit.</param>
/// <returns>
/// The resulting <see cref=""IQuantity"" />.
/// </returns>
public IQuantity ToQuantity(IUnit unit)
{{
    return this.ToUnit(unit);
}}

/// <summary>
/// Converts this object to a <see cref=""{quantityModel.Name}"" /> using the specified unit.
/// </summary>
/// <param name=""unit"">The quantity unit.</param>
/// <returns>
/// The converted <see cref=""{quantityModel.Name}"" />.
/// </returns>
public {quantityModel.Name} ToUnit(IUnit unit)
{{
    return new {quantityModel.Name}(this.ToDouble(unit), unit);
}}

/// <summary>
/// Converts this object to a <see cref=""{quantityModel.Name}"" /> using the unit specified by the <see cref=""{quantityModel.Name}UnitSelector"" />.
/// </summary>
/// <param name=""unitSelector"">The unit selector.</param>
/// <returns>
/// The converted <see cref=""{quantityModel.Name}"" />.
/// </returns>
public {quantityModel.Name} ToUnit(SelectUnit<{quantityModel.Name}UnitSelector> unitSelector)
{{
    return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new {quantityModel.Name}UnitSelector())));
}}

/// <summary>
/// Converts this object to a <see cref=""double"" /> using the unit specified by the <see cref=""{quantityModel.Name}UnitSelector"" />.
/// </summary>
/// <param name=""unitSelector"">The unit selector.</param>
/// <returns>
/// The converted <see cref=""double"" />.
/// </returns>
public double ToDouble(SelectUnit<{quantityModel.Name}UnitSelector> unitSelector)
{{
    return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new {quantityModel.Name}UnitSelector())));
}}
");
    }
}