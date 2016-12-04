// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TokenMatcher.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Matches a string input to the given regex.
    /// </summary>
    public sealed class TokenMatcher
    {
        internal const string IdGroupName = "ID";

        private readonly Regex regex;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenMatcher"/> class.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <param name="regex">The regex.</param>
        public TokenMatcher(TokenType tokenType, Regex regex)
        {
            this.regex = regex;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Gets the type of the token.
        /// </summary>
        /// <value>
        /// The type of the token.
        /// </value>
        public TokenType TokenType { get; }

        /// <summary>
        /// Matches the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The match result.</returns>
        public Group Match(string input)
        {
            return this.regex.Match(input).Groups[IdGroupName];
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.regex.ToString();
        }
    }
}