// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExpressionParserTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Hierarchical.Parsing
{
    using System;
    using System.Collections.Generic;

    using FakeItEasy;

    using FluentAssertions;

    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;
    using Sundew.Quantities.Engine.Units;

    using Xunit;

    public class ExpressionParserTests
    {
        private readonly ExpressionParser testee;

        private readonly IUnitExpressionParser unitExpressionParser;

        public ExpressionParserTests()
        {
            this.unitExpressionParser = A.Fake<IUnitExpressionParser>();
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
            A.CallTo(() => this.unitExpressionParser.Parse(A<string>.Ignored, A<bool>.Ignored))
                .ReturnsLazily<Result<Expression, Error<UnitError>>, string, bool>(
                    (identifier, ignored) => Result.Success<Expression>(new UnitExpression(new Unit(identifier))));
            var lexemes = GetLexemes(tokens);

            var result = this.testee.Parse(lexemes, ParseSettings.DefaultInvariantCulture);

            precedenceNotationVisitor.Visit(result.Value).Should().Be(expectedUnit);
        }

        [Theory]
        [InlineData("1", new[] { "Ia", "O^", "O^", "." }, 2)]
        [InlineData("2", new[] { "Ia", "O^", "Ib", "." }, 2)]
        [InlineData("3", new[] { "Ia", "N3", "E" }, 1)]
        [InlineData("4", new[] { "O(", "Ia", "O*", "Ib", "." }, 4)]
        [InlineData("5", new[] { "O)", "Ia", "O/", "Ib", "O)", "." }, 0)]
        public void Parse_When_LexemesAreInvalid_Then_ParseExceptionShouldBeThrown(
            string testNumber,
            string[] tokens,
            int expectedPosition)
        {
            A.CallTo(() => this.unitExpressionParser.Parse(A<string>.Ignored, A<bool>.Ignored))
                .ReturnsLazily<Result<Expression, Error<UnitError>>, string, bool>(
                    (identifier, ignored) => Result.Success<Expression>(new UnitExpression(new Unit(identifier))));
            var lexemes = GetLexemes(tokens);

            Action act = () => this.testee.Parse(lexemes, ParseSettings.DefaultInvariantCulture);

            act.ShouldThrow<ExpressionParseException>().And.Error.Lexeme.Position.Should().Be(expectedPosition);
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