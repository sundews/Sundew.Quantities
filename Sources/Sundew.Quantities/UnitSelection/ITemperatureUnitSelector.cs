// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITemperatureUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Temperature"/> unit selector.
    /// </summary>
    public interface ITemperatureUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Kelvin.
        /// </summary>
        /// <value>
        /// The Kelvin.
        /// </value>
        Expression Kelvin { get; }

        /// <summary>
        /// Gets the Celsius.
        /// </summary>
        /// <value>
        /// The Celsius.
        /// </value>
        Expression Celsius { get; }

        /// <summary>
        /// Gets the Fahrenheit.
        /// </summary>
        /// <value>
        /// The Fahrenheit.
        /// </value>
        Expression Fahrenheits { get; }
    }
}