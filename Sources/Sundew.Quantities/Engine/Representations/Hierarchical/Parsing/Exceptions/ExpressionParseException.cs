namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;

    /// <summary>
    /// Exception for indicating a parse error.
    /// </summary>
    public sealed class ExpressionParseException : ParseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionParseException" /> class.
        /// </summary>
        /// <param name="error">The parse error.</param>
        public ExpressionParseException(Error<ExpressionError> error)
            : base(error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public Error<ExpressionError> Error { get; }
    }
}