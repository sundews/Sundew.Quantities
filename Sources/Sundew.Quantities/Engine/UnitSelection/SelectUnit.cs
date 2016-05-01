// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SelectUnit.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Delegate for selecting a unit.
    /// </summary>
    /// <typeparam name="TUnits">The type of the units.</typeparam>
    /// <param name="units">The units.</param>
    /// <returns>An <see cref="Expression"/>.</returns>
    public delegate Expression SelectUnit<in TUnits>(TUnits units);
}