// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IMagneticFluxUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="MagneticFlux"/> unit selector.
    /// </summary>
    public interface IMagneticFluxUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Weber.
        /// </summary>
        /// <value>
        /// The Weber.
        /// </value>
        Expression Webers { get; }
    }
}