namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using System;
    using System.Linq;

    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    using Xunit;

    public class LexicalAnalyzerTests
    {
        private readonly LexicalAnalyzer testee;

        public LexicalAnalyzerTests()
        {
            this.testee = new LexicalAnalyzer(TokenMatching.CompositeUnit);
        }
        
        [Theory]
        [InlineData("m*s⁻²", new[] { "m", "*", "s", "⁻²", "" })]
        [InlineData("km", new[] { "km", "" })]
        [InlineData("km^2", new[] { "km", "^", "2", "" })]
        [InlineData("km^2/km", new[] { "km", "^", "2", "/", "km", "" })]
        [InlineData(" m", new[] { " ", "m", "" })]
        [InlineData("km*km", new[] { "km", "*", "km", "" })]
        [InlineData("km/h^2", new[] { "km", "/", "h", "^", "2", "" })]
        [InlineData("m * m / m", new[] { "m", " ", "*", " ", "m", " ", "/", " ", "m", "" })]
        [InlineData("km*km/km", new[] { "km", "*", "km", "/", "km", "" })]
        [InlineData("(km*km)/m", new[] { "(", "km", "*", "km", ")", "/", "m", "" })]
        [InlineData("(m*m)/(km*km)", new[] { "(", "m", "*", "m", ")", "/", "(", "km", "*", "km", ")", "" })]
        public void Analyze_ThenResultShouldBeEquivalentToExpectedTokens(string input, string[] expectedTokens)
        {
            var result = this.testee.Analyze(input, true).Value.ToList();

            result.Select(x => x.Token).Should().BeEquivalentTo(expectedTokens);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("45.4324.32")]
        [InlineData("45.4324,32")]
        public void Analyze_WhenInputIsInvalid_ThenLexicalExceptionShouldBeThrown(string input)
        {
            Action act = () => this.testee.Analyze(input, true);

            act.ShouldThrow<LexicalException>();
        }
    }
}