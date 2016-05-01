// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IEnergyUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Energy"/> unit selector.
    /// </summary>
    public interface IEnergyUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Joule.
        /// </summary>
        /// <value>
        /// The Joule.
        /// </value>
        Expression Joules { get; }
    }
}