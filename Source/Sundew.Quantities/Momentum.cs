// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Momentum.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents a momentum quantity.
    /// </summary>
    public partial struct Momentum
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Momentum> operator *(Momentum lhs, Momentum rhs)
        {
            return new Squared<Momentum>(new Momentum(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}