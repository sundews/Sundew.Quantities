// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Mass.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Spacetime;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a mass quantity.
    /// </summary>
    public partial class Mass
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Force operator *(Mass lhs, Quotient<Distance, Squared<Time>> rhs)
        {
            return new Force(QuantityOperations.Multiply(lhs, rhs.GetResult()));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Momentum operator *(Mass lhs, Velocity rhs)
        {
            return new Momentum(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Pressure operator /(Mass lhs, Product<Distance, Squared<Time>> rhs)
        {
            return new Pressure(QuantityOperations.Divide(lhs, rhs.GetResult()));
        }
    }
}