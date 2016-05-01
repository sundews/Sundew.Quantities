// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Area.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents an area quantity.
    /// </summary>
    public partial class Area
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Volume operator *(Area lhs, Distance rhs)
        {
            return new Volume(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Distance operator /(Area lhs, Distance rhs)
        {
            return new Distance(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Squared{TBase}"/> to <see cref="Area"/>.
        /// </summary>
        /// <param name="area">The area as a <see cref="Squared{Distance}"/>.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Area(Squared<Distance> area)
        {
            return new Area(area.GetResult());
        }
    }
}