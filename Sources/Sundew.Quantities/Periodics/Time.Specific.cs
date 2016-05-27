// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Time.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Periodics
{
    using System;

    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Spacetime;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a time quantity. 
    /// </summary>
    public partial class Time
    {
        /// <summary>
        /// Performs an implicit conversion from <see cref="TimeSpan"/> to <see cref="Time"/>.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Time(TimeSpan timeSpan)
        {
            return new Time(timeSpan.TotalSeconds);
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Distance operator *(Time lhs, Velocity rhs)
        {
            return new Distance(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Velocity operator *(Time lhs, Acceleration rhs)
        {
            return new Velocity(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Frequency operator /(double lhs, Time rhs)
        {
            return new Frequency(
                lhs / rhs.Value,
                UnitSystem.Instance.GetUnit(ConstantExpression.One / rhs.Unit.GetExpression()));
        }
    }
}