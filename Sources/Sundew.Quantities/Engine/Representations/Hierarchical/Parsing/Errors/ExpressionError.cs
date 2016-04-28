namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors
{
    /// <summary>
    /// Enum for expression errors.
    /// </summary>
    public enum ExpressionError
    {
        /// <summary>
        /// The lexical analysis failed.
        /// </summary>
        LexicalAnalysisFailed,

        /// <summary>
        /// The identifier not found.
        /// </summary>
        IdentifierNotFound,

        /// <summary>
        /// The number not found.
        /// </summary>
        NumberNotFound,

        /// <summary>
        /// The right parenthesis not found.
        /// </summary>
        RightParenthesisNotFound,

        /// <summary>
        /// The right weak parenthesis not found.
        /// </summary>
        RightWeakParenthesisNotFound,

        /// <summary>
        /// The end of data not found.
        /// </summary>
        EndOfDataNotFound
    }
}