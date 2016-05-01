// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IIlluminanceFluxUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Illuminance"/> unit selector.
    /// </summary>
    public interface IIlluminanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the lux.
        /// </summary>
        /// <value>
        /// The lux <see cref="Expression"/>.
        /// </value>
        Expression Lux { get; }
    }
}