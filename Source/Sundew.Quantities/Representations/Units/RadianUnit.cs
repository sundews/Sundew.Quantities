// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RadianUnit.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Units;

using System;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Extends <see cref="Unit"/> with proper formatting for the radian unit.
/// </summary>
public class RadianUnit : Unit
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RadianUnit"/> class.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    /// <param name="notation">The notation.</param>
    public RadianUnit(Prefix prefix, string notation)
        : base(prefix, notation)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RadianUnit"/> class.
    /// </summary>
    /// <param name="notation">The notation.</param>
    public RadianUnit(string notation)
        : base(notation)
    {
    }

    /// <summary>
    /// Formats the value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="format">The format.</param>
    /// <param name="formatProvider">The format provider.</param>
    /// <returns>The value properly formatted for Radians.</returns>
    public override string FormatValue(double value, string format, IFormatProvider formatProvider)
    {
        if (value.Equals(0.0))
        {
            return base.FormatValue(value, format, formatProvider);
        }

        return $"{base.FormatValue(value / Math.PI, format, formatProvider)}π";
    }
}