﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExponentSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelection;

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Abstract class for implementing order an of magnitude selector.
/// </summary>
/// <typeparam name="TUnits">The type of the units.</typeparam>
/// <typeparam name="TPrefixesAndUnits">The type of the prefixed units.</typeparam>
public abstract class ExponentSelector<TUnits, TPrefixesAndUnits> : IExponentSelector<TPrefixesAndUnits>
    where TPrefixesAndUnits : IPrefixSelector<TUnits>
{
    private int actualExponent = 1;

    private Prefix actualPrefix;

    /// <summary>
    /// Gets the square.
    /// </summary>
    /// <value>
    /// The square.
    /// </value>
    public TPrefixesAndUnits Square => this.GetPrefixesAndUnits(2);

    /// <summary>
    /// Gets the cubic.
    /// </summary>
    /// <value>
    /// The cubic.
    /// </value>
    public TPrefixesAndUnits Cubic => this.GetPrefixesAndUnits(3);

    /// <summary>
    /// Gets the quartic.
    /// </summary>
    /// <value>
    /// The quartic.
    /// </value>
    public TPrefixesAndUnits Quartic => this.GetPrefixesAndUnits(4);

    /// <summary>
    /// Gets the quintic.
    /// </summary>
    /// <value>
    /// The quintic.
    /// </value>
    public TPrefixesAndUnits Quintic => this.GetPrefixesAndUnits(5);

    /// <summary>
    /// Specifies the exponent.
    /// </summary>
    /// <param name="exponent">The exponent.</param>
    public void SpecifyExponent(int exponent)
    {
        this.actualExponent = exponent;
    }

    /// <summary>
    /// Specifies the prefix.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    public void SpecifyPrefix(Prefix prefix)
    {
        this.actualPrefix = prefix;
    }

    /// <summary>
    /// Selects the unit based on the specified magnitude, prefix and base unit.
    /// </summary>
    /// <param name="unit">The unit.</param>
    /// <returns>
    /// A <see cref="UnitBuilder"/>.
    /// </returns>
    public Expression SpecifyUnit(IUnit unit)
    {
        var exponent = this.actualExponent;
        var prefix = this.actualPrefix;
        this.actualExponent = 1;
        this.actualPrefix = null;

        if (prefix != null)
        {
            unit = unit.GetPrefixedUnit(prefix);
        }

        if (exponent > 1)
        {
            return new MagnitudeExpression(unit.GetExpression(), new ConstantExpression(exponent));
        }

        return unit.GetExpression();
    }

    /// <summary>
    /// Gets the prefixes and unit selector.
    /// </summary>
    /// <returns>The available prefixes and units.</returns>
    protected abstract TPrefixesAndUnits GetPrefixesAndUnits();

    /// <summary>
    /// Gets the prefixes and unit selector.
    /// </summary>
    /// <param name="exponent">The exponent.</param>
    /// <returns>
    /// The available prefixes and units.
    /// </returns>
    private TPrefixesAndUnits GetPrefixesAndUnits(int exponent)
    {
        this.SpecifyExponent(exponent);
        return this.GetPrefixesAndUnits();
    }
}