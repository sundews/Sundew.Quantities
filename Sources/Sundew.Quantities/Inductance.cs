// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inductance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents a inductance quantity.
    /// </summary>
    public partial struct Inductance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Inductance> operator *(Inductance lhs, Inductance rhs)
        {
            return new Squared<Inductance>(new Inductance(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}