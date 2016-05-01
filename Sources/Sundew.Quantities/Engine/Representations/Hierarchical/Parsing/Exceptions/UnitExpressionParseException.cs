// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitExpressionParseException.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;

    /// <summary>
    /// Exception for parsing an unit expression.
    /// </summary>
    /// <seealso cref="Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions.ParseException" />
    public class UnitExpressionParseException : ParseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExpressionParseException"/> class.
        /// </summary>
        /// <param name="error">The error.</param>
        public UnitExpressionParseException(Error<UnitError> error)
            : base(error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public Error<UnitError> Error { get; }
    }
}