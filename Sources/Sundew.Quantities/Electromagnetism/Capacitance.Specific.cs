// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Capacitance.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine;

    /// <summary>
    /// Represents a capacitance quantity.
    /// </summary>
    public partial class Capacitance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Charge operator *(Capacitance lhs, Potential rhs)
        {
            return new Charge(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}