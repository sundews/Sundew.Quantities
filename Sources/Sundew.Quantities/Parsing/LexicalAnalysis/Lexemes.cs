// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Lexemes.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.LexicalAnalysis
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains <see cref="Lexeme"/>s for a parser.
    /// </summary>
    public sealed class Lexemes : IEnumerable<Lexeme>
    {
        private LinkedListNode<Lexeme> currentLexeme;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lexemes"/> class.
        /// </summary>
        /// <param name="lexemes">The lexemes.</param>
        public Lexemes(LinkedList<Lexeme> lexemes)
        {
            Contract.Requires(lexemes != null);

            this.currentLexeme = lexemes.First;
        }

        /// <summary>
        /// Gets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public Lexeme Current => this.currentLexeme?.Value;

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>An <see cref="IEnumerator{Lexeme}"/>.</returns>
        public IEnumerator<Lexeme> GetEnumerator()
        {
            return this.currentLexeme.List.GetEnumerator();
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Accepts the token from.
        /// </summary>
        /// <param name="tokenRegex">The token regex.</param>
        /// <param name="token">The token.</param>
        /// <returns>
        ///   <c>true</c> if the specified token regex matches the token, otherwise <c>false</c>.
        /// </returns>
        public bool AcceptTokenFrom(Regex tokenRegex, out string token)
        {
            Contract.Requires(tokenRegex != null);

            return this.AcceptTokenFrom(tokenRegex, true, out token);
        }

        /// <summary>
        /// Accepts the token from a regex.
        /// </summary>
        /// <param name="tokenRegex">The token regex.</param>
        /// <param name="ignoreWhiteSpace">if set to <c>true</c> white space will be ignored.</param>
        /// <param name="token">The token.</param>
        /// <returns>
        ///   <c>true</c> if the specified token regex matches the token, otherwise <c>false</c>.
        /// </returns>
        public bool AcceptTokenFrom(Regex tokenRegex, bool ignoreWhiteSpace, out string token)
        {
            Contract.Requires(tokenRegex != null);

            var ignoredWhiteSpace = this.TryIgnoreWhiteSpace(ignoreWhiteSpace, this.Current);
            var match = tokenRegex.Match(this.Current.Token);
            if (match.Success)
            {
                token = match.Value;
                this.MoveToNext();
                return true;
            }

            if (ignoredWhiteSpace)
            {
                this.MoveToPrevious();
            }

            token = null;
            return false;
        }

        /// <summary>
        /// Accepts the token from a registry.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="possibleTokens">The possible tokens.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if the specified lexeme registry contains the token, otherwise <c>false</c>.</returns>
        public bool AcceptTokenFrom<TResult>(ILexemeRegistry<TResult> possibleTokens, out TResult result)
        {
            Contract.Requires(possibleTokens != null);

            return this.AcceptTokenFrom(possibleTokens, true, out result);
        }

        /// <summary>
        /// Accepts the token from.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="possibleTokens">The possible tokens.</param>
        /// <param name="ignoreWhiteSpace">if set to <c>true</c> white space will be ignored.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        ///   <c>true</c> if the token was accepted, otherwise <c>false</c>.
        /// </returns>
        public bool AcceptTokenFrom<TResult>(
            ILexemeRegistry<TResult> possibleTokens,
            bool ignoreWhiteSpace,
            out TResult result)
        {
            Contract.Requires(possibleTokens != null);

            var ignoredWhiteSpace = this.TryIgnoreWhiteSpace(ignoreWhiteSpace, this.Current);
            if (possibleTokens.TryGet(this.Current.Token, out result))
            {
                this.MoveToNext();
                return true;
            }

            if (ignoredWhiteSpace)
            {
                this.MoveToPrevious();
            }

            return false;
        }

        /// <summary>
        /// Accepts the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="ignoreWhiteSpace">if set to <c>true</c> white space will be ignored.</param>
        /// <returns>
        ///   <c>true</c> if the specified token is accepted, otherwise <c>false</c>.
        /// </returns>
        public bool AcceptToken(string token, bool ignoreWhiteSpace = true)
        {
            var ignoredWhiteSpace = this.TryIgnoreWhiteSpace(ignoreWhiteSpace, this.Current);
            if (this.Current.Token == token)
            {
                this.MoveToNext();
                return true;
            }

            if (ignoredWhiteSpace)
            {
                this.MoveToPrevious();
            }

            return false;
        }

        /// <summary>
        /// Accepts the type of the token.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <returns>
        ///   <c>true</c> if the specified token type is accepted, otherwise <c>false</c>.
        /// </returns>
        public bool AcceptTokenType(TokenType tokenType)
        {
            string token;
            return this.AcceptTokenType(tokenType, true, out token);
        }

        /// <summary>
        /// Accepts the type of the token.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <param name="token">The token.</param>
        /// <returns><c>true</c> if the specified token type is accepted, otherwise <c>false</c>.</returns>
        public bool AcceptTokenType(TokenType tokenType, out string token)
        {
            return this.AcceptTokenType(tokenType, true, out token);
        }

        /// <summary>
        /// Accepts the type of the token.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <param name="ignoreWhiteSpace">if set to <c>true</c> white space will be ignored.</param>
        /// <param name="token">The token.</param>
        /// <returns><c>true</c> if the specified token type is accepted, otherwise <c>false</c>.</returns>
        public bool AcceptTokenType(TokenType tokenType, bool ignoreWhiteSpace, out string token)
        {
            if (tokenType == TokenType.WhiteSpace)
            {
                ignoreWhiteSpace = false;
            }

            var ignoredWhiteSpace = this.TryIgnoreWhiteSpace(ignoreWhiteSpace, this.Current);
            var lexeme = this.Current;
            if (lexeme.TokenType == tokenType)
            {
                token = lexeme.Token;
                this.MoveToNext();
                return true;
            }

            if (ignoredWhiteSpace)
            {
                this.MoveToPrevious();
            }

            token = null;
            return false;
        }

        /// <summary>
        /// Moves to previous.
        /// </summary>
        /// <returns>The previous <see cref="Lexeme"/>.</returns>
        public Lexeme MoveToPrevious()
        {
            this.currentLexeme = this.currentLexeme.Previous;
            return this.currentLexeme.Value;
        }

        private bool TryIgnoreWhiteSpace(bool ignoreWhiteSpace, Lexeme lexeme)
        {
            if (ignoreWhiteSpace && lexeme.TokenType == TokenType.WhiteSpace)
            {
                this.MoveToNext();
                return true;
            }

            return false;
        }

        private void MoveToNext()
        {
            this.currentLexeme = this.currentLexeme.Next;
        }
    }
}