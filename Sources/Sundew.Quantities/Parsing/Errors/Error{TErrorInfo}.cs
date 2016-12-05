// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Error{TErrorInfo}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.Errors
{
    using System.Text;
    using Sundew.Quantities.Parsing.LexicalAnalysis;

    /// <summary>
    /// Represents a parser error.
    /// </summary>
    public class Error<TErrorInfo> : IError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error{TErrorInfo}" /> class.
        /// </summary>
        /// <param name="errorInfo">The error identifier.</param>
        /// <param name="lexeme">The lexeme.</param>
        /// <param name="innerError">The inner error.</param>
        internal Error(TErrorInfo errorInfo, Lexeme lexeme, IError innerError)
        {
            this.ErrorInfo = errorInfo;
            this.Lexeme = lexeme;
            this.InnerError = innerError;
        }

        /// <summary>
        /// Gets the lexeme.
        /// </summary>
        /// <value>
        /// The lexeme.
        /// </value>
        public Lexeme Lexeme { get; }

        /// <summary>
        /// Gets the unit error.
        /// </summary>
        /// <value>
        /// The unit error.
        /// </value>
        public IError InnerError { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has inner error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has inner error; otherwise, <c>false</c>.
        /// </value>
        public bool HasInnerError => this.InnerError != null;

        /// <summary>
        /// Gets the type of the error.
        /// </summary>
        /// <value>
        /// The type of the error.
        /// </value>
        public TErrorInfo ErrorInfo { get; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <returns>
        /// The error message.
        /// </returns>
        public string GetMessage()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"Error: {this.ErrorInfo}");
            if (this.Lexeme != null)
            {
                stringBuilder.Append($"- Invalid token {this.Lexeme.Token} at: {this.Lexeme.Position}");
            }

            if (this.HasInnerError)
            {
                stringBuilder.Append($" Inner Error: {this.InnerError.GetMessage()}");
            }

            return stringBuilder.ToString();
        }
    }
}