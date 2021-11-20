// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotationParameters.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors;

using System;
using System.Text;

/// <summary>
/// Contains parameters for <see cref="NotationVisitor"/>
/// </summary>
public sealed class NotationParameters
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotationParameters"/> class.
    /// </summary>
    /// <param name="formatProvider">The format provider.</param>
    /// <param name="stringBuilder">The string builder.</param>
    public NotationParameters(IFormatProvider formatProvider, StringBuilder stringBuilder = null)
    {
        this.FormatProvider = formatProvider;
        this.StringBuilder = stringBuilder ?? new StringBuilder();
    }

    /// <summary>
    /// Gets the format provider.
    /// </summary>
    /// <value>
    /// The format provider.
    /// </value>
    public IFormatProvider FormatProvider { get; }

    /// <summary>
    /// Gets the string builder.
    /// </summary>
    /// <value>
    /// The string builder.
    /// </value>
    public StringBuilder StringBuilder { get; }
}