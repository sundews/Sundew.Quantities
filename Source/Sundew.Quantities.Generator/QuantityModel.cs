// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityModel.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator;

using System.Collections.Generic;

/// <summary>
/// Model representing quantities for code generation.
/// </summary>
/// <seealso cref="Sundew.Quantities.Generator.IQuantityModel" />
public class QuantityModel : IQuantityModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QuantityModel" /> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="units">The units.</param>
    /// <param name="baseUnit">The base unit.</param>
    /// <param name="defaultUnits">The default units.</param>
    public QuantityModel(string name, IReadOnlyList<UnitModel> units, string baseUnit, IReadOnlyList<string> defaultUnits)
    {
        this.Name = name;
        this.Units = units;
        this.BaseUnit = baseUnit;
        this.DefaultUnits = defaultUnits;
    }

    public string Name { get; }

    public IReadOnlyList<UnitModel> Units { get; }

    public string BaseUnit { get; }

    public IReadOnlyList<string> DefaultUnits { get; }
}