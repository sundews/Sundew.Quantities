// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Area.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents an area quantity.
    /// </summary>
    public partial struct Area
    {
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
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Area> operator *(Area lhs, Area rhs)
        {
            return new Squared<Area>(new Area(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}