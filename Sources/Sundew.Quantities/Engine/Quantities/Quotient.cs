// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quotient.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Represents the product of two serializable <see cref="IDeferredQuantity"/>s.
    /// </summary>
    /// <typeparam name="TNominator">The type of the multiplier quantity.</typeparam>
    /// <typeparam name="TDenominator">The type of the multiplicand quantity.</typeparam>
    public class Quotient<TNominator, TDenominator> : IDeferredQuantity
        where TNominator : IDeferredQuantity
        where TDenominator : IDeferredQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quotient{TNominator, TDenominator}" /> class.
        /// </summary>
        /// <param name="nominator">The multiplier.</param>
        /// <param name="denominator">The multiplicand.</param>
        public Quotient(TNominator nominator, TDenominator denominator)
        {
            this.Nominator = nominator;
            this.Denominator = denominator;
        }

        /// <summary>
        /// Gets the nominator.
        /// </summary>
        /// <value>
        /// The nominator.
        /// </value>
        public TNominator Nominator { get; }

        /// <summary>
        /// Gets the denominator.
        /// </summary>
        /// <value>
        /// The denominator.
        /// </value>
        public TDenominator Denominator { get; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>A <see cref="Quantity"/>.</returns>
        public IQuantity GetResult()
        {
            return QuantityOperations.Multiply(this.Nominator.GetResult(), this.Denominator.GetResult());
        }
    }
}