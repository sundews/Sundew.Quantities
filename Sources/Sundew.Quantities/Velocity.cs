// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Velocity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a velocity quantity.
    /// </summary>
    public partial struct Velocity
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Distance operator *(Velocity lhs, Time rhs)
        {
            return new Distance(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Acceleration operator /(Velocity lhs, Time rhs)
        {
            return new Acceleration(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Velocity> operator *(Velocity lhs, Velocity rhs)
        {
            return new Squared<Velocity>(new Velocity(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}