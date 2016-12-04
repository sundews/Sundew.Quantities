// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pressure.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a pressure quantity.
    /// </summary>
    public partial struct Pressure
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product.</returns>
        public static Energy operator *(Pressure lhs, Volume rhs)
        {
            return new Energy(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Pressure> operator *(Pressure lhs, Pressure rhs)
        {
            return new Squared<Pressure>(new Pressure(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}