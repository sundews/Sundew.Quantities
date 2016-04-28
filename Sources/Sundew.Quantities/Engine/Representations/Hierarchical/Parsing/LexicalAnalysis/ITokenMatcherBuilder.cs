namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for implementing a token matcher builder.
    /// </summary>
    public interface ITokenMatcherBuilder
    {
        /// <summary>
        /// Builds a <see cref="TokenMatcher"/> based on the specified valid tokens.
        /// </summary>
        /// <param name="validTokens">The valid tokens.</param>
        /// <param name="areOptional">If set to <c>true</c> the tokens are optional.</param>
        /// <returns>A new <see cref="TokenMatcher"/>.</returns>
        TokenMatcher Build(IEnumerable<string> validTokens, bool areOptional);
    }
}