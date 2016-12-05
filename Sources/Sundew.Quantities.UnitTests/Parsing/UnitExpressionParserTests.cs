// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitExpressionParserTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Parsing
{
    using System.Collections.Generic;
    using System.Linq;
    using FakeItEasy;
    using FluentAssertions;
    using Sundew.Base.Computation;
    using Sundew.Quantities.Parsing;
    using Sundew.Quantities.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class UnitExpressionParserTests
    {
        private readonly ILexicalAnalyzer lexicalAnalyzer;

        private readonly UnitExpressionParser testee;

        public UnitExpressionParserTests()
        {
            var unitRegistry = new UnitRegistry();
            this.lexicalAnalyzer = A.Fake<ILexicalAnalyzer>();
            this.testee = new UnitExpressionParser(unitRegistry, this.lexicalAnalyzer);
        }

        [Theory]
        [InlineData(new[] { "Im", "E" }, "m")]
        [InlineData(new[] { "Is", "E" }, "s")]
        [InlineData(new[] { "Ik", "Im", "E" }, "km")]
        [InlineData(new[] { "Im", "Imi", "E" }, "mmi")]
        [InlineData(new[] { "Ida", "Is", "E" }, "das")]
        [InlineData(new[] { "Iμ", "Im", "E" }, "μm")]
        [InlineData(new[] { "IG", "I°C", "E" }, "G°C")]
        public void Parse_Then_ResultShouldHaveExpectedValues(string[] tokens, string expectedNotation)
        {
            A.CallTo(() => this.lexicalAnalyzer.Analyze(expectedNotation, A<bool>.Ignored))
                .Returns(Result.Success(GetLexemes(tokens)));

            var result = this.testee.Parse(expectedNotation, false);

            result.Value.ToString().Should().Be(expectedNotation);
        }

        private static Lexemes GetLexemes(IEnumerable<string> tokens)
        {
            var linkedList = new LinkedList<Lexeme>();
            foreach (var token in tokens)
            {
                var tokenType = TokenType.Identifier;
                switch (token[0])
                {
                    case 'E':
                        tokenType = TokenType.End;
                        break;
                }

                linkedList.AddLast(new Lexeme(token.Substring(1), tokenType, 0));
            }

            return new Lexemes(linkedList);
        }

        private class UnitRegistry : IUnitRegistry
        {
            private readonly Dictionary<string, Prefix> prefixes;

            private readonly Dictionary<string, IUnit> units;

            public UnitRegistry()
            {
                this.prefixes = UnitDefinitions.GetDefaultPrefixes().ToDictionary(x => x.Notation, x => x);
                this.units = UnitDefinitions.GetDefaultUnits().ToDictionary(x => x.ToString(), x => x);
            }

            public bool TryGet(string input, out IUnit result)
            {
                return this.units.TryGetValue(input, out result);
            }

            public bool TryGet(string input, out Prefix result)
            {
                return this.prefixes.TryGetValue(input, out result);
            }

            public IEnumerable<string> GetUnitNotations()
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<string> GetPrefixNotations()
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<IUnit> GetUnits()
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<Prefix> GetPrefixes()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}