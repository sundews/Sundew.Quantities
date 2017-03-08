// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversionParameters.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Contains parameters for <see cref="ExpressionToFlatRepresentationConverter"/>.
    /// </summary>
    public class ConversionParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionParameters"/> class.
        /// </summary>
        /// <param name="reduceUsingBaseUnits">if set to <c>true</c> [reduce using base units].</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        public ConversionParameters(bool reduceUsingBaseUnits, FlatRepresentationBuilder flatRepresentationBuilder)
        {
            this.ReduceUsingBaseUnits = reduceUsingBaseUnits;
            this.FlatRepresentationBuilder = flatRepresentationBuilder;
        }

        /// <summary>
        /// Gets a value indicating whether [reduce using base units].
        /// </summary>
        /// <value>
        /// <c>true</c> if [reduce using base units]; otherwise, <c>false</c>.
        /// </value>
        public bool ReduceUsingBaseUnits { get; }

        /// <summary>
        /// Gets the flat representation builder.
        /// </summary>
        /// <value>
        /// The flat representation builder.
        /// </value>
        public FlatRepresentationBuilder FlatRepresentationBuilder { get; }
    }
}