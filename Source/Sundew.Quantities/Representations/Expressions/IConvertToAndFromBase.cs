// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConvertToAndFromBase.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Interface for implementing class that can convert value to and from its base value.
/// </summary>
public interface IConvertToAndFromBase
{
    /// <summary>
    /// Converts the specified value into the unit's base value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The unit's base value.</returns>
    double ToBase(double value);

    /// <summary>
    /// Converts the specified value from the SI base value into the unit value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The unit's value.</returns>
    double FromBase(double value);
}