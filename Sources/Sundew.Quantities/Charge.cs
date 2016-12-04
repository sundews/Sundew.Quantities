// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Charge.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a charge quantity.
    /// </summary>
    public partial struct Charge
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The <see cref="Energy"/>.</returns>
        public static Energy operator *(Charge lhs, Potential rhs)
        {
            return new Energy(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The <see cref="ElectricCurrent"/>.</returns>
        public static ElectricCurrent operator /(Charge lhs, Time rhs)
        {
            return new ElectricCurrent(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Charge> operator *(Charge lhs, Charge rhs)
        {
            return new Squared<Charge>(new Charge(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}