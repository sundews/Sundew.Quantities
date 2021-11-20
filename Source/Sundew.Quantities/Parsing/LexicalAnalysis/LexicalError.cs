// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LexicalError.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.LexicalAnalysis;

/// <summary>
/// Settings for lexical analysis.
/// </summary>
public class LexicalError : IError
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LexicalError" /> class.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="position">The position.</param>
    public LexicalError(string input, int position)
    {
        this.Input = input == null ? "<null>" : input == string.Empty ? "<empty>" : input;
        this.Position = position;
    }

    /// <summary>
    /// Gets the input.
    /// </summary>
    /// <value>
    /// The input.
    /// </value>
    public string Input { get; }

    /// <summary>
    /// Gets the position.
    /// </summary>
    /// <value>
    /// The position.
    /// </value>
    public int Position { get; }

    /// <summary>
    /// Gets the message.
    /// </summary>
    /// <returns>
    /// The error message.
    /// </returns>
    public string GetMessage()
    {
        return $"Invalid input: {this.Input} at position: {this.Position}";
    }
}