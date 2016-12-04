// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Frequency.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a frequency quantity.
    /// </summary>
    public partial struct Frequency
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Squared<Frequency> operator *(Frequency lhs, Frequency rhs)
        {
            return new Squared<Frequency>(new Frequency(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }
    }
}