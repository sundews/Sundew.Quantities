// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Resistance.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents a resistance quantity.
    /// </summary>
    public partial class Resistance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Potential operator *(Resistance lhs, ElectricCurrent rhs)
        {
            return new Potential(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Inductance operator *(Resistance lhs, Time rhs)
        {
            return new Inductance(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}