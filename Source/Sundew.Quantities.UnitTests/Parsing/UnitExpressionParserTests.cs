﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExpressionParserTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Parsing
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Moq;
    using Sundew.Base.Primitives.Computation;
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
            this.lexicalAnalyzer = New.Mock<ILexicalAnalyzer>();
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
            this.lexicalAnalyzer.Setup(x => x.Analyze(expectedNotation, It.IsAny<bool>()))
                .Returns(Result.Success(GetLexemes(tokens)));

            var result = this.testee.Parse(expectedNotation, false);

            result.Value.ToString().Should().Be(expectedNotation);
        }

        private static Lexemes GetLexemes(IEnumerable<string> tokens)
        {
            var linkedList = new LinkedList<Lexeme>();
            foreach (var token in tokens)
            {
                var tokenType = token[0] switch
                {
                    'E' => TokenType.End,
                    _ => TokenType.Identifier
                };

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