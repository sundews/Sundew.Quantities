// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IVolumeUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Unit selector for volume.
    /// </summary>
    public interface IVolumeUnitSelector : IDistanceUnitSelector
    {
        /// <summary>
        /// Gets the liter.
        /// </summary>
        /// <value>The liter <see cref="Expression"/>.</value>
        Expression Liters { get; }
    }
}