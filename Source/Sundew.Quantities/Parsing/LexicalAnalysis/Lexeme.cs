// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Lexeme.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Parsing.LexicalAnalysis;

/// <summary>
/// Contains information about a token, its type and position.
/// </summary>
public sealed class Lexeme
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Lexeme"/> class.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="tokenType">Type of the token.</param>
    /// <param name="position">The position.</param>
    public Lexeme(string token, TokenType tokenType, int position)
    {
        this.Token = token;
        this.TokenType = tokenType;
        this.Position = position;
    }

    /// <summary>
    /// Gets the token.
    /// </summary>
    /// <value>
    /// The token.
    /// </value>
    public string Token { get; }

    /// <summary>
    /// Gets the type of the token.
    /// </summary>
    /// <value>
    /// The type of the token.
    /// </value>
    public TokenType TokenType { get; }

    /// <summary>
    /// Gets the position.
    /// </summary>
    /// <value>
    /// The position.
    /// </value>
    public int Position { get; }

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return this.Token;
    }
}