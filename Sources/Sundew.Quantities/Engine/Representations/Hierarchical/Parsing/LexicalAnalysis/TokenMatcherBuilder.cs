// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TokenMatcherBuilder.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Default implementation of <see cref="ITokenMatcherBuilder"/>.
    /// </summary>
    public sealed class TokenMatcherBuilder : ITokenMatcherBuilder
    {
        private const string StartStringAndNonCaptureGroup = @"^(?<" + TokenMatcher.IdGroupName + ">";

        private const string OrName = "|";

        private const string EndGroupOptionalName = @")?.+$";

        private const string EndGroupName = ")$";

        /// <summary>
        /// Builds a <see cref="TokenMatcher" /> based on the specified valid tokens.
        /// </summary>
        /// <param name="validTokens">The valid tokens.</param>
        /// <param name="areOptional">If set to <c>true</c> the tokens are optional.</param>
        /// <returns>
        /// A new <see cref="TokenMatcher" />.
        /// </returns>
        public TokenMatcher Build(IEnumerable<string> validTokens, bool areOptional)
        {
            var matchStringBuilder = new StringBuilder(StartStringAndNonCaptureGroup);
            foreach (var notation in validTokens)
            {
                matchStringBuilder.Append(notation + OrName);
            }

            matchStringBuilder.Remove(matchStringBuilder.Length - 1, 1);

            if (areOptional)
            {
                matchStringBuilder.Append(EndGroupOptionalName);
            }
            else
            {
                matchStringBuilder.Append(EndGroupName);
            }

            return new TokenMatcher(TokenType.Identifier, new Regex(matchStringBuilder.ToString()));
        }
    }
}