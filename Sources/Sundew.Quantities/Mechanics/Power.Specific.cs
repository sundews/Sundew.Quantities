// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Power.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Electromagnetism;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents a power quantity.
    /// </summary>
    public partial class Power
    {
        /// <summary>
        /// Divides the lhs with the rhs.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The resulting <see cref="Energy"/>.
        /// </returns>
        public static Energy operator *(Power lhs, Time rhs)
        {
            return new Energy(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the lhs with the rhs.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The resulting <see cref="Potential"/>.
        /// </returns>
        public static Potential operator /(Power lhs, ElectricCurrent rhs)
        {
            return new Potential(QuantityOperations.Divide(lhs, rhs));
        }
    }
}