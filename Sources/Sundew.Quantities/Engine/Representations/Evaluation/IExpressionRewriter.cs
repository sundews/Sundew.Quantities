// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IExpressionRewriter.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing an <see cref="Expression"/> rewriter.
    /// </summary>
    public interface IExpressionRewriter
    {
        /// <summary>
        /// Rewrites the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnits">If set to <c>true</c> the expression is reduced by the base unit.</param>
        /// <param name="flatRepresentationConsumer">The flat representation consumer.</param>
        /// <returns>The rewritten <see cref="Expression"/>.</returns>
        Expression Rewrite(
            Expression expression,
            bool reduceByBaseUnits,
            FlatRepresentationConsumer flatRepresentationConsumer);
    }
}