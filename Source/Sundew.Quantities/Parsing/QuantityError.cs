// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityError.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Parsing;

/// <summary>
/// Enum for errors when parsing quantities.
/// </summary>
public enum QuantityError
{
    /// <summary>
    /// The number not found.
    /// </summary>
    NumberNotFound,

    /// <summary>
    /// The unit not found.
    /// </summary>
    UnitNotFound,

    /// <summary>
    /// The end of data not found.
    /// </summary>
    EndOfDataNotFound
}