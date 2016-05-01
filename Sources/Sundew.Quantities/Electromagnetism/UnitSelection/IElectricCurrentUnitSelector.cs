// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IElectricCurrentUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="ElectricCurrent"/> unit selector.
    /// </summary>
    public interface IElectricCurrentUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the ampere.
        /// </summary>
        /// <value>
        /// The ampere.
        /// </value>
        Expression Amperes { get; }
    }
}