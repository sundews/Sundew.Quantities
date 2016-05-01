// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IUnitExpressionParser.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing
{
    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;

    /// <summary>
    /// Interface for implementing an unit expression parser.
    /// </summary>
    public interface IUnitExpressionParser
    {
        /// <summary>
        /// Parses the specified unit.
        /// </summary>
        /// <param name="unit">The unit <see cref="string" />.</param>
        /// <param name="throwOnError">If set to <c>true</c> an exception is thrown in case an error occurs.</param>
        /// <returns>
        /// A <see cref="Result{Expression, TError}" /> where TError is <see cref="Error{UnitError}"/>.
        /// </returns>
        Result<Expression, Error<UnitError>> Parse(string unit, bool throwOnError);
    }
}