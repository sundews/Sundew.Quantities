// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFlatIdentifierRepresentation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Flat;

using System;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Flat presentation of an identifier.
/// </summary>
public interface IFlatIdentifierRepresentation : IEquatable<IFlatIdentifierRepresentation>
{
    /// <summary>
    /// Converts this instance to the resulting expression.
    /// </summary>
    /// <returns>A <see cref="Expression"/>.</returns>
    Expression ToResultingExpression();
}