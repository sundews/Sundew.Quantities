// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotationOptions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors;

using System.Globalization;

/// <summary>
/// Options for the <see cref="NotationVisitor"/>
/// </summary>
public class NotationOptions
{
    private const OperationOrderFormat DefaultOperationOrderFormat = OperationOrderFormat.None;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotationOptions"/> class.
    /// </summary>
    /// <param name="magnitudeFormat">The magnitude format.</param>
    /// <param name="orderFormat">The order format.</param>
    private NotationOptions(MagnitudeFormat magnitudeFormat, OperationOrderFormat orderFormat)
    {
        this.MagnitudeFormat = magnitudeFormat;
        this.OrderFormat = orderFormat;
    }

    /// <summary>
    /// Gets the default.
    /// </summary>
    /// <value>
    /// The default.
    /// </value>
    public static NotationOptions Default { get; } = From(
        MagnitudeFormat.UseAboveLetter,
        DefaultOperationOrderFormat);

    /// <summary>
    /// Gets the magnitude format.
    /// </summary>
    /// <value>
    /// The magnitude format.
    /// </value>
    public MagnitudeFormat MagnitudeFormat { get; }

    /// <summary>
    /// Gets the order format.
    /// </summary>
    /// <value>
    /// The order format.
    /// </value>
    public OperationOrderFormat OrderFormat { get; }

    /// <summary>
    /// Creates a <see cref="NotationOptions"/> from <see cref="OperationOrderFormat"/>.
    /// </summary>
    /// <param name="operationOrderFormat">The operation order format.</param>
    /// <returns>
    /// A <see cref="NotationOptions" />.
    /// </returns>
    public static implicit operator NotationOptions(OperationOrderFormat operationOrderFormat)
    {
        return From(MagnitudeFormat.UseAboveLetter, operationOrderFormat);
    }

    /// <summary>
    /// Creates a <see cref="NotationOptions"/> from <see cref="MagnitudeFormat"/>.
    /// </summary>
    /// <param name="magnitudeFormat">The magnitude format.</param>
    /// <returns>
    /// A <see cref="NotationOptions" />.
    /// </returns>
    public static implicit operator NotationOptions(MagnitudeFormat magnitudeFormat)
    {
        return From(magnitudeFormat, DefaultOperationOrderFormat);
    }

    /// <summary>
    /// Creates a <see cref="NotationOptions" /> from <see cref="CultureInfo" /> and <see cref="MagnitudeFormat" />.
    /// </summary>
    /// <param name="magnitudeFormat">The magnitude format.</param>
    /// <returns>
    /// A <see cref="NotationOptions" />.
    /// </returns>
    public static NotationOptions From(MagnitudeFormat magnitudeFormat)
    {
        return new NotationOptions(magnitudeFormat, DefaultOperationOrderFormat);
    }

    /// <summary>
    /// Creates a <see cref="NotationOptions" /> from <see cref="CultureInfo" /> and <see cref="OperationOrderFormat" />.
    /// </summary>
    /// <param name="operationOrderFormat">The order format.</param>
    /// <returns>
    /// A <see cref="NotationOptions" />.
    /// </returns>
    public static NotationOptions From(OperationOrderFormat operationOrderFormat)
    {
        return new NotationOptions(MagnitudeFormat.UseAboveLetter, operationOrderFormat);
    }

    /// <summary>
    /// Creates a <see cref="NotationOptions"/> from <see cref="MagnitudeFormat"/> and <see cref="OperationOrderFormat"/>.
    /// </summary>
    /// <param name="magnitudeFormat">The magnitude format.</param>
    /// <param name="operationOrderFormat">The order format.</param>
    /// <returns>
    /// A <see cref="NotationOptions" />.
    /// </returns>
    public static NotationOptions From(MagnitudeFormat magnitudeFormat, OperationOrderFormat operationOrderFormat)
    {
        return new NotationOptions(magnitudeFormat, operationOrderFormat);
    }
}