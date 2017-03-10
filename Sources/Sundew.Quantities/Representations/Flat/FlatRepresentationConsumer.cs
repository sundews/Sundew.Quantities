// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatRepresentationConsumer.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Flat
{
    using System.Collections.Generic;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Allows consuming <see cref="IFlatIdentifierRepresentation"/>s once when converting then back into <see cref="Expression"/>s.
    /// </summary>
    public sealed class FlatRepresentationConsumer
    {
        private readonly Dictionary<string, IFlatIdentifierRepresentation> flatIdentifierRepresentations;

        private readonly HashSet<string> usedExpressions;

        internal FlatRepresentationConsumer(
            Dictionary<string, IFlatIdentifierRepresentation> flatIdentifierRepresentations)
        {
            this.flatIdentifierRepresentations = flatIdentifierRepresentations;
            this.usedExpressions = new HashSet<string>();
        }

        /// <summary>
        /// Gets the resulting expression.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> reduction will be done using base units.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public Expression GetResultingExpression(UnitExpression unitExpression, bool reduceByBaseUnit)
        {
            var unitNotation = reduceByBaseUnit ? unitExpression.Unit.BaseUnit.Notation : unitExpression.Unit.Notation;
            return this.GetResultingExpression(unitNotation);
        }

        /// <summary>
        /// Gets the resulting expression.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public Expression GetResultingExpression(ConstantExpression constantExpression)
        {
            return this.GetResultingExpression(FlatRepresentationBuilder.Constant);
        }

        /// <summary>
        /// Gets the resulting expression.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public Expression GetResultingExpression(VariableExpression variableExpression)
        {
            return this.GetResultingExpression(variableExpression.VariableName);
        }

        private Expression GetResultingExpression(string identifier)
        {
            IFlatIdentifierRepresentation flatIdentifierRepresentation;
            if (this.flatIdentifierRepresentations.TryGetValue(identifier, out flatIdentifierRepresentation)
                && !this.usedExpressions.Contains(identifier))
            {
                this.usedExpressions.Add(identifier);
                return flatIdentifierRepresentation.ToResultingExpression();
            }

            return null;
        }
    }
}