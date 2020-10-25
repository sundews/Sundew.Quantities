// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LuminousIntensity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents a luminous intensity quantity.
    /// </summary>
    public partial struct LuminousIntensity
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static LuminousFlux operator *(LuminousIntensity lhs, SolidAngle rhs)
        {
            return new LuminousFlux(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<LuminousIntensity> operator *(LuminousIntensity lhs, LuminousIntensity rhs)
        {
            return new Squared<LuminousIntensity>(new LuminousIntensity(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}