﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitRegistry.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing;

using System.Collections.Generic;
using Sundew.Quantities.Parsing.LexicalAnalysis;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Interface for implementing a unit registry.
/// </summary>
public interface IUnitRegistry : ILexemeRegistry<IUnit>, ILexemeRegistry<Prefix>
{
    /// <summary>
    /// Gets the unit notations.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{String}"/>.</returns>
    IEnumerable<string> GetUnitNotations();

    /// <summary>
    /// Gets the prefix notations.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{String}"/>.</returns>
    IEnumerable<string> GetPrefixNotations();

    /// <summary>
    /// Gets the units.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{IUnit}" />.
    /// </returns>
    IEnumerable<IUnit> GetUnits();

    /// <summary>
    /// Gets the prefixes.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{Prefix}" />.
    /// </returns>
    IEnumerable<Prefix> GetPrefixes();
}