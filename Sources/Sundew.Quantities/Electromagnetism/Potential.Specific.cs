// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Potential.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Mechanics;

    /// <summary>
    /// Represents a potential quantity.
    /// </summary>
    public partial class Potential
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
    }
}