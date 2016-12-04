// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Potential.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a potential quantity.
    /// </summary>
    public partial struct Potential
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Power operator *(Potential lhs, ElectricCurrent rhs)
        {
            return new Power(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static ElectricCurrent operator /(Potential lhs, Resistance rhs)
        {
            return new ElectricCurrent(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Resistance operator /(Potential lhs, ElectricCurrent rhs)
        {
            return new Resistance(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Potential> operator *(Potential lhs, Potential rhs)
        {
            return new Squared<Potential>(new Potential(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}