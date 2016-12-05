// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitExpressionParser.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing
{
    using Sundew.Base.Computation;
    using Sundew.Quantities.Parsing.Errors;
    using Sundew.Quantities.Representations.Expressions;

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