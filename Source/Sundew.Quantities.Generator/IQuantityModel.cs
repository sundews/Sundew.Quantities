// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantityModel.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator;

using System.Collections.Generic;
using Sundew.Generator.Core;

[DefaultImplementation(typeof(QuantityModel))]
public interface IQuantityModel
{
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    string Name { get; }

    /// <summary>
    /// Gets the units.
    /// </summary>
    /// <value>
    /// The units.
    /// </value>
    IReadOnlyList<UnitModel> Units { get; }

    /// <summary>
    /// Gets the base unit.
    /// </summary>
    /// <value>
    /// The base unit.
    /// </value>
    string BaseUnit { get; }

    /// <summary>
    /// Gets the default units.
    /// </summary>
    /// <value>
    /// The default units.
    /// </value>
    IReadOnlyList<string> DefaultUnits { get; }
}