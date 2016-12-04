// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CharacterConverter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Hierarchical.Internals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class CharacterConverter
    {
        private static readonly IDictionary<char, char> CharacterToAboveCharacter = new Dictionary<char, char>();

        private static readonly IDictionary<char, char> AboveCharacterToCharacter = new Dictionary<char, char>();

        static CharacterConverter()
        {
            CharacterToAboveCharacter.Add('0', Constants.Exponent0);
            CharacterToAboveCharacter.Add('1', Constants.Exponent1);
            CharacterToAboveCharacter.Add('2', Constants.Exponent2);
            CharacterToAboveCharacter.Add('3', Constants.Exponent3);
            CharacterToAboveCharacter.Add('4', Constants.Exponent4);
            CharacterToAboveCharacter.Add('5', Constants.Exponent5);
            CharacterToAboveCharacter.Add('6', Constants.Exponent6);
            CharacterToAboveCharacter.Add('7', Constants.Exponent7);
            CharacterToAboveCharacter.Add('8', Constants.Exponent8);
            CharacterToAboveCharacter.Add('9', Constants.Exponent9);
            CharacterToAboveCharacter.Add('.', Constants.DotAbove);
            CharacterToAboveCharacter.Add(',', Constants.CommaAbove);
            CharacterToAboveCharacter.Add('-', Constants.SuperScriptMinus);
            CharacterToAboveCharacter.Add('(', Constants.LeftParentheseAbove);
            CharacterToAboveCharacter.Add(')', Constants.RightParentheseAbove);

            AboveCharacterToCharacter.Add(Constants.Exponent0, '0');
            AboveCharacterToCharacter.Add(Constants.Exponent1, '1');
            AboveCharacterToCharacter.Add(Constants.Exponent2, '2');
            AboveCharacterToCharacter.Add(Constants.Exponent3, '3');
            AboveCharacterToCharacter.Add(Constants.Exponent4, '4');
            AboveCharacterToCharacter.Add(Constants.Exponent5, '5');
            AboveCharacterToCharacter.Add(Constants.Exponent6, '6');
            AboveCharacterToCharacter.Add(Constants.Exponent7, '7');
            AboveCharacterToCharacter.Add(Constants.Exponent8, '8');
            AboveCharacterToCharacter.Add(Constants.Exponent9, '9');
            AboveCharacterToCharacter.Add(Constants.DotAbove, '.');
            AboveCharacterToCharacter.Add(Constants.CommaAbove, ',');
            AboveCharacterToCharacter.Add(Constants.SuperScriptMinus, '-');
            AboveCharacterToCharacter.Add(Constants.LeftParentheseAbove, '(');
            AboveCharacterToCharacter.Add(Constants.RightParentheseAbove, ')');
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
                char charaterAbove;
                if (exponents.TryGetValue(character, out charaterAbove))
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
    }
}