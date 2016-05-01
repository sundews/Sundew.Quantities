// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IResistanceUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Resistance"/> unit selector.
    /// </summary>
    public interface IResistanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the ohm.
        /// </summary>
        /// <value>
        /// The ohm <see cref="Expression"/>.
        /// </value>
        Expression Ohms { get; }
    }
}