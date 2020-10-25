// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RewritingParameters.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Contains parameters for <see cref="ExpressionRewriter"/>.
    /// </summary>
    public class RewritingParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RewritingParameters"/> class.
        /// </summary>
        /// <param name="reduceByBaseUnit">if set to <c>true</c> [reduce by base unit].</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        public RewritingParameters(bool reduceByBaseUnit, FlatRepresentationConsumer flatRepresentationConsumer)
        {
            this.ReduceByBaseUnit = reduceByBaseUnit;
            this.FlatRepresentationConsumer = flatRepresentationConsumer;
        }

        /// <summary>
        /// Gets a value indicating whether [reduce by base unit].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [reduce by base unit]; otherwise, <c>false</c>.
        /// </value>
        public bool ReduceByBaseUnit { get; }

        /// <summary>
        /// Gets the flat representation consumer.
        /// </summary>
        /// <value>
        /// The flat representation consumer.
        /// </value>
        public FlatRepresentationConsumer FlatRepresentationConsumer { get; }
    }
}