// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPowerUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Power"/> unit selector.
    /// </summary>
    public interface IPowerUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the watt.
        /// </summary>
        /// <value>
        /// The watt <see cref="Expression"/>.
        /// </value>
        Expression Watts { get; }
    }
}