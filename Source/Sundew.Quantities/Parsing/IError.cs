// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IError.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Parsing;

/// <summary>
/// Interface for representing an error.
/// </summary>
public interface IError
{
    /// <summary>
    /// Gets the message.
    /// </summary>
    /// <returns>The error message.</returns>
    string GetMessage();
}