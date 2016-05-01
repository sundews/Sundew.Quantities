// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ITemperatureUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Thermodynamics.UnitSelection
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