// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Illuminance.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a illuminance quantity.
    /// </summary>
    public partial struct Illuminance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Product<Illuminance, Time> operator *(Illuminance lhs, Time rhs)
        {
            return new Product<Illuminance, Time>(lhs, rhs);
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Illuminance> operator *(Illuminance lhs, Illuminance rhs)
        {
            return new Squared<Illuminance>(new Illuminance(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}