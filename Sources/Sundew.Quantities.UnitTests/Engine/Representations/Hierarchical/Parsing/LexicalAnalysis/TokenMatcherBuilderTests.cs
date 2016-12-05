// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TokenMatcherBuilderTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Parsing.LexicalAnalysis;

namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using FluentAssertions;
    using Xunit;

    public class TokenMatcherBuilderTests
    {
        private readonly TokenMatcherBuilder testee;

        public TokenMatcherBuilderTests()
        {
            this.testee = new TokenMatcherBuilder();
        }

        [Theory]
        [InlineData(
            new[] { "Y", "Z", "P", "T", "G", "M", "k", "h", "da", "d", "c", "m", "µ", "n", "p", "f", "a", "z", "y" },
            true, @"^(?<ID>Y|Z|P|T|G|M|k|h|da|d|c|m|µ|n|p|f|a|z|y)?.+$")]
        [InlineData(
            new[]
                {
                    "mi", "m", "in", "f", "yd", "nmi", "y", "mon", "w", "d", "h", "min", "s", "A", "V", "R", "K", "C", "F",
                    "mol", "cd"
                }, false, @"^(?<ID>mi|m|in|f|yd|nmi|y|mon|w|d|h|min|s|A|V|R|K|C|F|mol|cd)$")]
        public void Build_ThenResultStringShouldBeExpectedRegex(
            string[] validTokens,
            bool areOptional,
            string expectedRegex)
        {
            var result = this.testee.Build(validTokens, areOptional);

            result.ToString().Should().Be(expectedRegex);
        }
    }
}