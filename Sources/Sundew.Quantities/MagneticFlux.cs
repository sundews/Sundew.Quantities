// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagneticFlux.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents a magnetic flux quantity.
    /// </summary>
    public partial struct MagneticFlux
    {
        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Inductance operator /(MagneticFlux lhs, ElectricCurrent rhs)
        {
            return new Inductance(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static MagneticFluxDensity operator /(MagneticFlux lhs, Area rhs)
        {
            return new MagneticFluxDensity(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<MagneticFlux> operator *(MagneticFlux lhs, MagneticFlux rhs)
        {
            return new Squared<MagneticFlux>(new MagneticFlux(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}