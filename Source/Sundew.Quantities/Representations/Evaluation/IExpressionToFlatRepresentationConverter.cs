// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExpressionToFlatRepresentationConverter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Interface for implementing an <see cref="Expression"/> to <see cref="FlatRepresentation"/> converter.
    /// </summary>
    public interface IExpressionToFlatRepresentationConverter
    {
        /// <summary>
        /// Converts the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <param name="flatRepresentationBuilder">The flat representation builder.</param>
        /// <returns>A <see cref="FlatRepresentation"/>.</returns>
        FlatRepresentation Convert(
            Expression expression,
            bool reduceUsingBaseUnits,
            FlatRepresentationBuilder flatRepresentationBuilder);
    }
}