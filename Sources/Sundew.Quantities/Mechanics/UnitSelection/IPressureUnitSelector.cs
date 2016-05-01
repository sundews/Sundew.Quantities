// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPressureUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Pressure"/> unit selector.
    /// </summary>
    public interface IPressureUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the pascal.
        /// </summary>
        /// <value>
        /// The pascal <see cref="Expression"/>.
        /// </value>
        Expression Pascals { get; }

        /// <summary>
        /// Gets the bar.
        /// </summary>
        /// <value>
        /// The bar <see cref="Expression"/>.
        /// </value>
        Expression Bars { get; }

        /// <summary>
        /// Gets the Technical Atmosphere.
        /// </summary>
        /// <value>
        /// The Technical Atmosphere.
        /// </value>
        Expression TechnicalAtmospheres { get; }

        /// <summary>
        /// Gets the Standard Atmosphere.
        /// </summary>
        /// <value>
        /// The Standard Atmosphere.
        /// </value>
        Expression StandardAtmospheres { get; }

        /// <summary>
        /// Gets the Torr.
        /// </summary>
        /// <value>
        /// The Torr <see cref="Expression"/>.
        /// </value>
        Expression Torrs { get; }

        /// <summary>
        /// Gets the pounds per square inch.
        /// </summary>
        /// <value>
        /// The pounds per square inch.
        /// </value>
        Expression Psi { get; }
    }
}