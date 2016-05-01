// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IVelocityUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spacetime.UnitSelection
{
    using Sundew.Quantities.Periodics.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Velocity"/> unit selector.
    /// </summary>
    public interface IVelocityUnitSelector : IDistanceUnitSelector, ITimeUnitSelector
    {
    }
}