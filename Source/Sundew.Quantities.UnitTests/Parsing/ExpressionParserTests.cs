// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionParserTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Parsing
{
    using System;
    using System.Collections.Generic;
    using FluentAssertions;
    using Moq;
    using Sundew.Base.Primitives.Computation;
    using Sundew.Quantities.Parsing;
    using Sundew.Quantities.Parsing.Errors;
    using Sundew.Quantities.Parsing.Exceptions;
    using Sundew.Quantities.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Expressions.Visitors;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class ExpressionParserTests
    {
        private readonly ExpressionParser testee;

        private readonly IUnitExpressionParser unitExpressionParser;

        public ExpressionParserTests()
        {
            this.unitExpressionParser = New.Mock<IUnitExpressionParser>();
            this.testee = new ExpressionParser(this.unitExpressionParser);
        }

        [Theory]
        [InlineData(new[] { "Ia", "E⁻²", "O/", "Ib", "." }, "a⁻²/b")]
        [InlineData(new[] { "Ia", "O^", "N2", "O/", "Ib", "." }, "a²/b")]
        [InlineData(new[] { "Ia", "O^", "N2", "O^", "N3", "." }, "{a²}^³")]
        [InlineData(new[] { "Ia", "O^", "N2", "." }, "a²")]
        [InlineData(new[] { "Ia", "O/", "Ib", "O*", "Ic", "O/", "Id", "." }, "a/b*c/d")]
        [InlineData(new[] { "O(", "Ia", "O/", "Ib", "O)", "O*", "Ic", "." }, "(a/b)*c")]
        [InlineData(new[] { "Ic", "O*", "O{", "Ia", "O/", "Ib", "O}", "." }, "c*{a/b}")]
        [InlineData(new[] { "Ia", "O*", "O{", "Ib", "O/", "Ic", "O}", "." }, "a*{b/c}")]
        [InlineData(new[] { "Ia", "O*", "O{", "Ib", "O*", "Ic", "O}", "." }, "a*{b*c}")]
        public void Parse_Then_ResultShouldBeExpectedUnit(string[] tokens, string expectedUnit)
        {
            var precedenceNotationVisitor = new NotationVisitor(
                NotationOptions.From(OperationOrderFormat.CurlyBrackets));
            this.unitExpressionParser.Setup(x => x.Parse(It.IsAny<string>(), It.IsAny<bool>()))
                .Returns<string, bool>(
                    (identifier, _) => Result.Success<Expression>(new UnitExpression(new Unit(identifier))));
            var lexemes = GetLexemes(tokens);

            var result = this.testee.Parse(lexemes, ParseSettings.DefaultInvariantCulture);

            precedenceNotationVisitor.Visit(result.Value).Should().Be(expectedUnit);
        }

        [Theory]
        [InlineData(new[] { "Ia", "O^", "O^", "." }, 2)]
        [InlineData(new[] { "Ia", "O^", "Ib", "." }, 2)]
        [InlineData(new[] { "Ia", "N3", "E" }, 1)]
        [InlineData(new[] { "O(", "Ia", "O*", "Ib", "." }, 4)]
        [InlineData(new[] { "O)", "Ia", "O/", "Ib", "O)", "." }, 0)]
        public void Parse_When_LexemesAreInvalid_Then_ParseExceptionShouldBeThrown(
            string[] tokens,
            int expectedPosition)
        {
            this.unitExpressionParser.Setup(x => x.Parse(It.IsAny<string>(), It.IsAny<bool>()))
                .Returns<string, bool>(
                    (identifier, _) => Result.Success<Expression>(new UnitExpression(new Unit(identifier))));
            var lexemes = GetLexemes(tokens);

            Action act = () => this.testee.Parse(lexemes, ParseSettings.DefaultInvariantCulture);

            act.Should().Throw<ExpressionParseException>().And.Error.Lexeme.Position.Should().Be(expectedPosition);
        }

        private static Lexemes GetLexemes(IEnumerable<string> tokens)
        {
            var linkedList = new LinkedList<Lexeme>();
            var index = 0;
            foreach (var token in tokens)
            {
                linkedList.AddLast(new Lexeme(token.Substring(1), GetTokenType(token), index++));
            }

            return new Lexemes(linkedList);
        }

        private static TokenType GetTokenType(string lexeme)
        {
            switch (lexeme[0])
            {
                case 'O':
                    return TokenType.Operator;
                case 'I':
                    return TokenType.Identifier;
                case 'N':
                    return TokenType.Number;
                case 'E':
                    return TokenType.Exponent;
                default:
                    return TokenType.End;
            }
        }
    }
}