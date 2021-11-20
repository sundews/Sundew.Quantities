// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LexicalAnalyzer.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.LexicalAnalysis;

using System.Collections.Generic;
using Sundew.Base.Primitives.Computation;

/// <summary>
/// Default implementation of <see cref="ILexicalAnalyzer"/>.
/// </summary>
public sealed class LexicalAnalyzer : ILexicalAnalyzer
{
    private readonly IEnumerable<TokenMatcher> tokenMatchers;

    /// <summary>
    /// Initializes a new instance of the <see cref="LexicalAnalyzer"/> class.
    /// </summary>
    /// <param name="tokenMatchers">The token matchers.</param>
    public LexicalAnalyzer(IEnumerable<TokenMatcher> tokenMatchers)
    {
        this.tokenMatchers = tokenMatchers;
    }

    /// <summary>
    /// Analyzes the specified input and generates a list of lexemes.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="throwOnError">If set to <c>true</c> an exception will be thrown on error.</param>
    /// <returns>
    /// A <see cref="Lexemes" />.
    /// </returns>
    /// <exception cref="LexicalException">Thrown if input is invalid.</exception>
    public Result<Lexemes, LexicalError> Analyze(string input, bool throwOnError)
    {
        var lexemes = new LinkedList<Lexeme>();
        if (string.IsNullOrEmpty(input))
        {
            return GetError(input, throwOnError, 0);
        }

        var characterPosition = 0;
        while (characterPosition < input.Length)
        {
            var currentInput = input.Substring(characterPosition);
            var lexeme = this.FindLexeme(currentInput, characterPosition);
            if (lexeme != null)
            {
                characterPosition += lexeme.Token.Length;
                lexemes.AddLast(lexeme);
            }
            else
            {
                return GetError(input[characterPosition].ToString(), throwOnError, characterPosition);
            }
        }

        lexemes.AddLast(new Lexeme(string.Empty, TokenType.End, characterPosition));
        return Result.Success(new Lexemes(lexemes));
    }

    private static Result<Lexemes, LexicalError> GetError(string input, bool throwOnError, int characterPosition)
    {
        var lexicalError = new LexicalError(input, characterPosition);
        if (throwOnError)
        {
            throw new LexicalException(lexicalError);
        }

        return Result.Error(lexicalError);
    }

    private Lexeme FindLexeme(string input, int characterPosition)
    {
        foreach (var tokenMatcher in this.tokenMatchers)
        {
            var match = tokenMatcher.Match(input);
            if (match.Success)
            {
                return new Lexeme(match.Value, tokenMatcher.TokenType, characterPosition);
            }
        }

        return null;
    }
}