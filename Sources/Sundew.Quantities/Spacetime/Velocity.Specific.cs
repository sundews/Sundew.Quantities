// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Velocity.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spacetime
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a velocity quantity.
    /// </summary>
    public partial class Velocity
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
    }
}