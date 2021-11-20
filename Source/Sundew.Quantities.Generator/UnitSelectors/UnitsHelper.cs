// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitsHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.UnitSelectors;

using System.Text;
using Sundew.Generator.Core;

public static class UnitsHelper
{
    public static IndentedString GetUnits(IQuantityModel modelModel)
    {
        var stringBuilder = new StringBuilder();
        foreach (var modelDefinitionUnit in modelModel.Units)
        {
            stringBuilder.AppendLine($@"
/// <summary>
/// Gets the {GetDocumentationName(modelDefinitionUnit)} expression.
/// </summary>
/// <value>
/// The {GetDocumentationName(modelDefinitionUnit)}.
/// </value>
public Expression {modelDefinitionUnit.Identifier} => this.SpecifyUnit(UnitDefinitions.{GetUnitName(modelDefinitionUnit)});
");
        }

        return new IndentedString(8, stringBuilder.ToString());
    }

    internal static string GetUnitName(UnitModel unitModel)
    {
        if (!string.IsNullOrEmpty(unitModel.Unit))
        {
            return unitModel.Unit;
        }

        if (unitModel.Identifier[unitModel.Identifier.Length - 1] == 's')
        {
            return unitModel.Identifier.Substring(0, unitModel.Identifier.Length - 1);
        }

        return unitModel.Identifier;
    }

    internal static string GetDocumentationName(UnitModel unitModel)
    {
        if (!string.IsNullOrEmpty(unitModel.Name))
        {
            return unitModel.Name;
        }

        return unitModel.Identifier.TrimEnd('s').ToLower();
    }
}