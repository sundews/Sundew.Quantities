// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Distance.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Spacetime;

    /// <summary>
    /// Implementation of the Distance base unit.
    /// </summary>
    public partial class Distance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Area operator *(Distance lhs, Distance rhs)
        {
            return new Area(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Volume operator *(Distance lhs, Area rhs)
        {
            return new Volume(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Product<Distance, Squared<Time>> operator *(Distance lhs, Squared<Time> rhs)
        {
            return new Product<Distance, Squared<Time>>(lhs, rhs);
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Acceleration operator /(Distance lhs, Squared<Time> rhs)
        {
            return new Acceleration(QuantityOperations.Divide(lhs, rhs.GetResult()));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Velocity operator /(Distance lhs, Time rhs)
        {
            return new Velocity(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Time operator /(Distance lhs, Velocity rhs)
        {
            return new Time(QuantityOperations.Divide(lhs, rhs));
        }
    }
}