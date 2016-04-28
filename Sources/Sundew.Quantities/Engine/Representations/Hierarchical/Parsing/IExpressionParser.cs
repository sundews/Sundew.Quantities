namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing
{
    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    /// <summary>
    /// Interface for implementing an expression parser.
    /// </summary>
    public interface IExpressionParser
    {
        /// <summary>
        /// Parses the specified lexeme list.
        /// </summary>
        /// <param name="lexemes">The lexemes.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>The parsed expression.</returns>
        Result<Expression, Error<ExpressionError>> Parse(Lexemes lexemes, ParseSettings parseSettings);
    }
}