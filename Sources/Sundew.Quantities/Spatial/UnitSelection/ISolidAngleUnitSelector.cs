// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ISolidAngleUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Spatial.SolidAngle"/> unit selector.
    /// </summary>
    public interface ISolidAngleUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the steradian.
        /// </summary>
        /// <value>
        /// The steradian.
        /// </value>
        Expression Steradians { get; }
    }
}