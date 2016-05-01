// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ILuminousIntensityUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="LuminousIntensity"/> unit selector.
    /// </summary>
    public interface ILuminousIntensityUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the candela.
        /// </summary>
        /// <value>
        /// The candelas.
        /// </value>
        Expression Candelas { get; }
    }
}