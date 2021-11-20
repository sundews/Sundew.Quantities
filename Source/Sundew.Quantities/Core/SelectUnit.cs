// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectUnit.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Delegate for selecting a unit.
/// </summary>
/// <typeparam name="TUnits">The type of the units.</typeparam>
/// <param name="units">The units.</param>
/// <returns>An <see cref="Expression"/>.</returns>
public delegate Expression SelectUnit<in TUnits>(TUnits units);