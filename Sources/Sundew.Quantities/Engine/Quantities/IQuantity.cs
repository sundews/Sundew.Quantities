// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IQuantity.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Quantities
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing base unit quantities.
    /// </summary>
    public interface IQuantity : IFormattableQuantity,
                                 IComparable,
                                 IEquatable<IQuantity>,
                                 IComparable<IQuantity>,
                                 IUnitConvertible,
                                 IDeferredQuantity
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The quantity value.
        /// </value>
        double Value { get; }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <value>
        /// The quantity unit.
        /// </value>
        IUnit Unit { get; }
    }
}