// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolidAngle.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities
{
    using Sundew.Quantities.Core;

    /// <summary>
    /// Represents a solid angle quantity.
    /// </summary>
    public partial struct SolidAngle
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<SolidAngle> operator *(SolidAngle lhs, SolidAngle rhs)
        {
            return new Squared<SolidAngle>(new SolidAngle(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}