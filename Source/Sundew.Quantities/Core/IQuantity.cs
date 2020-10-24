// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using System;
    using Sundew.Quantities.Representations.Expressions;

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