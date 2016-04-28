namespace Sundew.Quantities.Engine.Parsing
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions;

    /// <summary>
    /// Exception for parsing quantities.
    /// </summary>
    public class QuantityParseException : ParseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityParseException" /> class.
        /// </summary>
        /// <param name="error">The error.</param>
        public QuantityParseException(Error<QuantityError> error)
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
        public Error<QuantityError> Error { get; }
    }
}