// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IUnitConvertible{TQuantity,TUnitSelector}.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Quantities
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for implementing unit conversion methods.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the value.</typeparam>
    /// <typeparam name="TUnitSelector">The type of the unit selector.</typeparam>
    public interface IUnitConvertible<out TQuantity, out TUnitSelector> : IUnitConvertible<TQuantity>
    {
        /// <summary>
        /// Converts this object to a <see cref="TQuantity"/> using the unit specified by the <see cref="TUnitSelector"/>.
        /// </summary>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The converted <see cref="TQuantity"/>.</returns>
        TQuantity ToUnit(SelectUnit<TUnitSelector> unitSelector);

        /// <summary>
        /// Converts this object to a <see cref="double"/> using the unit specified by the <see cref="TUnitSelector"/>.
        /// </summary>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The converted <see cref="double"/>.</returns>
        double ToDouble(SelectUnit<TUnitSelector> unitSelector);
    }
}