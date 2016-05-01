// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TokenMatching.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing
{
    using System.Text.RegularExpressions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    /// <summary>
    /// Contains token matcher for composite unit and simple units.
    /// </summary>
    public static class TokenMatching
    {
        /// <summary>
        /// The composite unit token matchers.
        /// </summary>
        public static readonly TokenMatcher[] CompositeUnit =
            {
                new TokenMatcher(
                    TokenType.Identifier,
                    new Regex(
                    @"^(?<ID>[A-Za-z\p{IsGreekandCoptic}\°]\w*)")),
                new TokenMatcher(
                    TokenType.Number,
                    new Regex(
                    @"^(?<ID>[-+]?(0|[1-9][0-9]*)((\.|\,)[0-9]*[1-9])?([eE][-+]?(0[0-9]*|[1-9][0-9]*))?)")),
                new TokenMatcher(
                    TokenType.Operator,
                    new Regex(@"^(?<ID>\*|/|\^|\(|\)|\{|\}|\·|\×)")),
                new TokenMatcher(
                    TokenType.Exponent,
                    new Regex(@"^(?<ID>(⁻?)(⁰|¹|²|³|⁴|⁵|⁶|⁷|⁸|⁹)+)")),
                new TokenMatcher(
                    TokenType.WhiteSpace,
                    new Regex(@"^(?<ID>\s+)"))
            };
    }
}