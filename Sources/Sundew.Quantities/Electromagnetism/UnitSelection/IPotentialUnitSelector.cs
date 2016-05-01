// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPotentialUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Potential"/> unit selector.
    /// </summary>
    public interface IPotentialUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <value>
        /// The volt <see cref="Expression"/>.
        /// </value>
        Expression Volts { get; }
    }
}