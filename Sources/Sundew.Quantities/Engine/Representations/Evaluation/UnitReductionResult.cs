// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitReductionResult.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Extends <see cref="ReductionResult"/> with the actual performed reductions.
    /// </summary>
    public sealed class UnitReductionResult : ReductionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitReductionResult" /> class.
        /// </summary>
        /// <param name="flatRepresentation">The flat representation.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> reducing was performed using the base unit.</param>
        /// <param name="reductions">The reductions.</param>
        /// <param name="hasReductions">If set to <c>true</c> the result has reductions.</param>
        public UnitReductionResult(
            FlatRepresentation flatRepresentation,
            Expression expression,
            bool reduceByBaseUnit,
            IEnumerable<Reduction> reductions,
            bool hasReductions)
            : base(flatRepresentation, expression, reduceByBaseUnit)
        {
            this.Reductions = reductions;
            this.HasReductions = hasReductions;
        }

        /// <summary>
        /// Gets the reductions.
        /// </summary>
        /// <value>
        /// The reductions.
        /// </value>
        public IEnumerable<Reduction> Reductions { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is reduced.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is reduced; otherwise, <c>false</c>.
        /// </value>
        public bool HasReductions { get; }

        /// <summary>
        /// Converts the RHS.
        /// </summary>
        /// <param name="rhsValue">The RHS value.</param>
        /// <returns>The converted value.</returns>
        public double ConvertRhs(double rhsValue)
        {
            foreach (var reduction in this.Reductions)
            {
                return reduction.ConvertRhs(rhsValue);
            }

            return rhsValue;
        }
    }
}