// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantityOperations.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Interface containing <see cref="IQuantity{TQuantity}"/> operations.
    /// </summary>
    public interface IQuantityOperations
    {
        /// <summary>
        /// Gets the addition operation.
        /// </summary>
        /// <value>
        /// The addition operation.
        /// </value>
        IQuantityOperation<IQuantity> Addition { get; }

        /// <summary>
        /// Gets the subtraction operation.
        /// </summary>
        /// <value>
        /// The subtraction operation.
        /// </value>
        IQuantityOperation<IQuantity> Subtraction { get; }

        /// <summary>
        /// Gets the multiplication operation.
        /// </summary>
        /// <value>
        /// The multiplication operation.
        /// </value>
        IQuantityOperation<IQuantity> Multiplication { get; }

        /// <summary>
        /// Gets the division operation.
        /// </summary>
        /// <value>
        /// The division operation.
        /// </value>
        IQuantityOperation<IQuantity> Division { get; }

        /// <summary>
        /// Gets the exponentiation operation.
        /// </summary>
        /// <value>
        /// The exponentiation operation.
        /// </value>
        IQuantityOperation<double> Exponentiation { get; }

        /// <summary>
        /// Gets the NTH root operation.
        /// </summary>
        /// <value>
        /// The NTH root operation.
        /// </value>
        IQuantityOperation<double> NthRoot { get; }

        /// <summary>
        /// Gets the convert to unit operation.
        /// </summary>
        /// <value>
        /// The convert to unit operation.
        /// </value>
        IQuantityAndUnitOperation ConvertToUnit { get; }
    }
}