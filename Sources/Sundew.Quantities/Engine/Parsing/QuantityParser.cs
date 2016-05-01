// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityParser.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Parsing
{
    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

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
            string number;
            if (lexemes.AcceptTokenType(TokenType.Number, out number))
            {
                var value = double.Parse(number, parseSettings.CultureInfo);
                var result = this.expressionParser.Parse(
                    lexemes,
                    new ParseSettings(parseSettings.CultureInfo, false, false));

                if (parseSettings.AssertEnd && lexemes.AcceptTokenType(TokenType.End))
                {
                    return GetError(parseSettings, QuantityError.EndOfDataNotFound, lexemes);
                }

                return Result.For(
                    result,
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
}