// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityParser.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core;

using Sundew.Base.Primitives.Computation;
using Sundew.Quantities.Parsing;
using Sundew.Quantities.Parsing.Errors;
using Sundew.Quantities.Parsing.LexicalAnalysis;

/// <summary>
/// Default implementation of <see cref="IQuantityParser"/>.
/// </summary>
public class QuantityParser : IQuantityParser
{
    private readonly IExpressionParser expressionParser;

    private readonly IUnitFactory unitFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuantityParser" /> class.
    /// </summary>
    /// <param name="expressionParser">The expression parser.</param>
    /// <param name="unitFactory">The unit factory.</param>
    public QuantityParser(IExpressionParser expressionParser, IUnitFactory unitFactory)
    {
        this.expressionParser = expressionParser;
        this.unitFactory = unitFactory;
    }

    /// <summary>
    /// Parses the specified quantity.
    /// </summary>
    /// <param name="lexemes">The lexemes.</param>
    /// <param name="parseSettings">The parse settings.</param>
    /// <returns>
    /// A <see cref="Quantity" />.
    /// </returns>
    /// <exception cref="QuantityParseException">Exception thrown when parsing fails.</exception>
    public Result<Quantity, Error<QuantityError>> Parse(Lexemes lexemes, ParseSettings parseSettings)
    {
        if (lexemes.AcceptTokenType(TokenType.Number, out var number))
        {
            var value = double.Parse(number, parseSettings.CultureInfo);
            var result = this.expressionParser.Parse(
                lexemes,
                new ParseSettings(parseSettings.CultureInfo, false, false));

            if (parseSettings.AssertEnd && lexemes.AcceptTokenType(TokenType.End))
            {
                return GetError(parseSettings, QuantityError.EndOfDataNotFound, lexemes);
            }

            return result.Convert(
                expression => new Quantity(value, this.unitFactory.Create(expression)),
                error => Error.From(QuantityError.UnitNotFound, lexemes.Current, error));
        }

        return GetError(parseSettings, QuantityError.NumberNotFound, lexemes);
    }

    private static Result<Quantity, Error<QuantityError>> GetError(
        ParseSettings parseSettings,
        QuantityError quantityError,
        Lexemes lexemes)
    {
        var error = Error.From(quantityError, lexemes.Current);
        if (parseSettings.ThrowOnError)
        {
            throw new QuantityParseException(error);
        }

        return Result.Error(error);
    }
}