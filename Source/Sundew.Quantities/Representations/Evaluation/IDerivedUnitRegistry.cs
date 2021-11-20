// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDerivedUnitRegistry.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation;

using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;
using Sundew.Quantities.Representations.Units;

/// <summary>
/// Interface for implementing a derived unit registry.
/// </summary>
public interface IDerivedUnitRegistry
{
    /// <summary>
    /// Tries to get the unit.
    /// </summary>
    /// <param name="flatRepresentation">The flat representation.</param>
    /// <param name="derivedUnit">The found derived unit.</param>
    /// <returns>
    ///   <c>true</c> if the flat representation is found, otherwise <c>false</c>
    /// </returns>
    bool TryGetUnit(FlatRepresentation flatRepresentation, out DerivedUnit derivedUnit);

    /// <summary>
    /// Tries to get the prefix.
    /// </summary>
    /// <param name="prefixFactor">The prefix factor.</param>
    /// <param name="prefix">The found prefix.</param>
    /// <returns>
    ///   <c>true</c> if the prefix factor is found, otherwise <c>false</c>
    /// </returns>
    bool TryGetPrefix(double prefixFactor, out Prefix prefix);
}