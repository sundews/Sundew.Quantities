// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ElectricCurrent.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents an electric current quantity.
    /// </summary>
    public partial class ElectricCurrent
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Charge operator *(ElectricCurrent lhs, Time rhs)
        {
            return new Charge(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Potential operator *(ElectricCurrent lhs, Resistance rhs)
        {
            return new Potential(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Power operator *(ElectricCurrent lhs, Potential rhs)
        {
            return new Power(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Conductance operator /(ElectricCurrent lhs, Potential rhs)
        {
            return new Conductance(QuantityOperations.Divide(lhs, rhs));
        }
    }
}