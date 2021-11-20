﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interval{TQuantity}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities;

using Sundew.Base.Primitives.Numeric;
using Sundew.Quantities.Core;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Represents a range of a given quantity.
/// </summary>
/// <typeparam name="TQuantity">The type of the quantity.</typeparam>
public sealed class Interval<TQuantity>
    where TQuantity : IQuantity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Interval{TQuantity}"/> class.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit.</param>
    public Interval(double min, double max, IUnit unit)
    {
        if (min > max)
        {
            throw new RangeException<double>(min, max);
        }

        this.Min = min;
        this.Max = max;
        this.Unit = unit;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Interval{TQuantity}"/> class.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="expression">The expression.</param>
    internal Interval(double min, double max, Expression expression)
        : this(min, max, UnitBuilder.BuildUnit(expression))
    {
    }

    /// <summary>
    /// Gets the minimum.
    /// </summary>
    /// <value>
    /// The minimum.
    /// </value>
    public double Min { get; }

    /// <summary>
    /// Gets the maximum.
    /// </summary>
    /// <value>
    /// The maximum.
    /// </value>
    public double Max { get; }

    /// <summary>
    /// Gets the unit.
    /// </summary>
    /// <value>
    /// The unit.
    /// </value>
    public IUnit Unit { get; }

    /// <summary>
    /// Gets the length.
    /// </summary>
    /// <value>
    /// The length.
    /// </value>
    public double Length => this.Max - this.Min;

    /// <summary>
    /// Gets the center.
    /// </summary>
    /// <value>
    /// The center.
    /// </value>
    public double Center => (this.Min + this.Max) / 2;

    /// <summary>
    /// Gets the radius.
    /// </summary>
    /// <value>
    /// The radius.
    /// </value>
    public double Radius => this.Length / 2;

    /// <summary>
    /// Determines whether this interval contains the specified quantity.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    /// <param name="intervalMode">The interval mode.</param>
    /// <returns>
    ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
    /// </returns>
    public bool Contains(TQuantity quantity, IntervalMode intervalMode = IntervalMode.Inclusive)
    {
        return quantity.ToDouble(this.Unit).IsWithinInterval(this.Min, this.Max, intervalMode);
    }

    /// <summary>
    /// Determines whether this interval contains the specified quantity.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    /// <returns>
    ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
    /// </returns>
    public bool ContainsInclusive(TQuantity quantity)
    {
        return this.Contains(quantity);
    }

    /// <summary>
    /// Determines whether this interval contains the specified quantity.
    /// </summary>
    /// <param name="quantity">The quantity.</param>
    /// <returns>
    ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
    /// </returns>
    public bool ContainsExclusive(TQuantity quantity)
    {
        return this.Contains(quantity, IntervalMode.Exclusive);
    }

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return $"Interval: {this.Min}, {this.Max} [{this.Unit}]";
    }
}