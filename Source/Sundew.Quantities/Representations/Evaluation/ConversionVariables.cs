// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversionVariables.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    /// <summary>
    /// Contains variables for <see cref="ExpressionToFlatRepresentationConverter"/>.
    /// </summary>
    public class ConversionVariables
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionVariables"/> class.
        /// </summary>
        public ConversionVariables()
            : this(1.0, false)
        {
        }

        internal ConversionVariables(double exponent, bool expressionIsPartOfDenominator)
        {
            this.Exponent = exponent;
            this.ExpressionIsPartOfDenominator = expressionIsPartOfDenominator;
        }

        /// <summary>
        /// Gets the exponent.
        /// </summary>
        /// <value>
        /// The exponent.
        /// </value>
        public double Exponent { get; }

        /// <summary>
        /// Gets a value indicating whether [expression is part of denominator].
        /// </summary>
        /// <value>
        /// <c>true</c> if [expression is part of denominator]; otherwise, <c>false</c>.
        /// </value>
        public bool ExpressionIsPartOfDenominator { get; }
    }
}