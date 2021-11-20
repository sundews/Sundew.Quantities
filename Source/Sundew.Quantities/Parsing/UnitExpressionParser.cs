﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExpressionParser.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing
{
    using System;
    using System.Text.RegularExpressions;
    using Sundew.Base.Primitives.Computation;
    using Sundew.Quantities.Parsing.Errors;
    using Sundew.Quantities.Parsing.Exceptions;
    using Sundew.Quantities.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Default implementation of <see cref="IUnitExpressionParser"/>.
    /// </summary>
    public class UnitExpressionParser : IUnitExpressionParser
    {
        private static readonly Regex VariableRegex = new(@"^\d+$");

        private readonly ILexicalAnalyzer lexicalAnalyzer;

        private readonly IUnitRegistry unitRegistry;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExpressionParser" /> class.
        /// </summary>
        /// <param name="unitRegistry">The unit registry.</param>
        /// <param name="lexicalAnalyzer">The lexical analyzer.</param>
        public UnitExpressionParser(IUnitRegistry unitRegistry, ILexicalAnalyzer lexicalAnalyzer)
        {
            this.unitRegistry = unitRegistry;
            this.lexicalAnalyzer = lexicalAnalyzer;
        }

        /// <summary>
        /// Tries to parses the specified unit.
        /// </summary>
        /// <param name="unit">The unit <see cref="string" />.</param>
        /// <param name="throwOnError">If set to <c>true</c> an exception is thrown in case of an error].</param>
        /// <returns>
        /// A <see cref="Result{Expression, Error}" />.of <see cref="Error{UnitError}" />
        /// </returns>
        public Result<Expression, Error<UnitError>> Parse(string unit, bool throwOnError)
        {
            try
            {
                var lexemesResult = this.lexicalAnalyzer.Analyze(unit, throwOnError);
                if (!lexemesResult)
                {
                    throw CreateParseException(UnitError.LexicalAnalysisFailed, null, lexemesResult.Error);
                }

                var lexemes = lexemesResult.Value;
                var result = Prefix(lexemes, this.unitRegistry);
                if (lexemes.AcceptTokenType(TokenType.End, out var token))
                {
                    return Result.Success(result);
                }

                throw CreateParseException(UnitError.EndOfDataNotFound, lexemes.Current);
            }
            catch (UnitExpressionParseException expressionParseException)
            {
                if (throwOnError)
                {
                    throw;
                }

                return Result.Error(expressionParseException.Error);
            }
        }

        private static Expression Prefix(Lexemes lexemes, IUnitRegistry unitRegistry)
        {
            IUnit unit;
            if (lexemes.AcceptTokenFrom(unitRegistry, out Prefix prefix))
            {
                if (lexemes.AcceptTokenFrom(unitRegistry, out unit))
                {
                    return Unit(prefix, unit);
                }

                lexemes.MoveToPrevious();
            }

            if (lexemes.AcceptTokenFrom(unitRegistry, out unit))
            {
                return Unit(null, unit);
            }

            if (lexemes.AcceptTokenFrom(VariableRegex, out var variable))
            {
                return new VariableExpression(variable);
            }

            throw CreateParseException(UnitError.PrefixUnitOrUnitOrVariableNotFound, lexemes.Current);
        }

        private static Expression Unit(Prefix prefix, IUnit unit)
        {
            if (prefix != null)
            {
                unit = unit.GetPrefixedUnit(prefix);
            }

            return unit.GetExpression();
        }

        private static Exception CreateParseException(UnitError unitError, Lexeme lexeme, IError innerError = null)
        {
            return new UnitExpressionParseException(Error.From(unitError, lexeme, innerError));
        }
    }
}