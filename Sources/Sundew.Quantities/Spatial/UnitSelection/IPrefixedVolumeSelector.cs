// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPrefixedVolumeSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for implementing prefixed volume selector.
    /// </summary>
    public interface IPrefixedVolumeSelector : IVolumeUnitSelector, IPrefixSelector<IVolumeUnitSelector>
    {
    }
}