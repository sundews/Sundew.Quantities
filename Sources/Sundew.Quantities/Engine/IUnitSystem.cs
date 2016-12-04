// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitSystem.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine
{
    using System.Collections.Generic;
    using System.Globalization;

    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing a unit system.
    /// </summary>
    public interface IUnitSystem
    {
        /// <summary>
        /// Gets the dependencies.
        /// </summary>
        /// <value>
        /// The dependencies.
        /// </value>
        UnitSystemDependencies Dependencies { get; }

        /// <summary>
        /// Gets the quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="cultureInfo">The culture information.</param>
        /// <returns>A new <see cref="Quantity"/>.</returns>
        Quantity GetQuantity(string quantity, CultureInfo cultureInfo);

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>
        /// An <see cref="IUnit" /> based on the specified <see cref="Expression"/>.
        /// </returns>
        IUnit GetUnit(Expression expression);

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <param name="unit">The unit as a string.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>
        /// An <see cref="IUnit" /> based on the specified <see cref="string" />.
        /// </returns>
        Result<IUnit, Error<ExpressionError>> GetUnit(string unit, ParseSettings parseSettings);

        /// <summary>
        /// Gets the prefixes.
        /// </summary>
        /// <returns>The prefixes.</returns>
        IEnumerable<Prefix> GetPrefixes();

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The units.</returns>
        IEnumerable<IUnit> GetUnits();
    }
}