// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperationOrderFormat.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Representations.Expressions.Visitors;

/// <summary>
/// Specifies the operation order format.
/// </summary>
public enum OperationOrderFormat
{
    /// <summary>
    /// No operation order will be shown.
    /// </summary>
    None,

    /// <summary>
    /// Curly Brackets will indicate precedence.
    /// </summary>
    CurlyBrackets,

    /// <summary>
    /// Parentheses will indicate the order.
    /// </summary>
    Parentheses,
}