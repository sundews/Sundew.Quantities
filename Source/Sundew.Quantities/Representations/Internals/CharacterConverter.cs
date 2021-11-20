// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CharacterConverter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Internals;

using System;
using System.Collections.Generic;
using System.Text;

internal static class CharacterConverter
{
    private static readonly IDictionary<char, char> CharacterToAboveCharacter = new Dictionary<char, char>();

    private static readonly IDictionary<char, char> AboveCharacterToCharacter = new Dictionary<char, char>();

    static CharacterConverter()
    {
        Add('0', Constants.Exponent0);
        Add('1', Constants.Exponent1);
        Add('2', Constants.Exponent2);
        Add('3', Constants.Exponent3);
        Add('4', Constants.Exponent4);
        Add('5', Constants.Exponent5);
        Add('6', Constants.Exponent6);
        Add('7', Constants.Exponent7);
        Add('8', Constants.Exponent8);
        Add('9', Constants.Exponent9);
        Add('.', Constants.DotAbove);
        Add(',', Constants.CommaAbove);
        Add('-', Constants.SuperScriptMinus);
        Add('(', Constants.LeftParentheseAbove);
        Add(')', Constants.RightParentheseAbove);
    }

    internal static string FromExponentNotation(string exponent)
    {
        return ExponentNotation(exponent, AboveCharacterToCharacter);
    }

    internal static string ToExponentNotation(string exponent)
    {
        return ExponentNotation(exponent, CharacterToAboveCharacter);
    }

    private static string ExponentNotation(string exponent, IDictionary<char, char> exponents)
    {
        var exponentNotation = new StringBuilder();
        for (int index = 0; index < exponent.Length; index++)
        {
            var character = exponent[index];
            if (exponents.TryGetValue(character, out var charaterAbove))
            {
                exponentNotation.Append(charaterAbove);
            }
            else
            {
                throw new NotSupportedException(
                    $"The character {character} in the text {exponent} does not have an equivalent representation.");
            }
        }

        return exponentNotation.ToString();
    }

    private static void Add(char normalCharacter, char raisedCharacter)
    {
        CharacterToAboveCharacter.Add(normalCharacter, raisedCharacter);
        AboveCharacterToCharacter.Add(raisedCharacter, normalCharacter);
    }
}