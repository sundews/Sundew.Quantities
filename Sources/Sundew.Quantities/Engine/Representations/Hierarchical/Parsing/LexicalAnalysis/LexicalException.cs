namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using System;

    /// <summary>
    /// Exception for indicating an invalid input.
    /// </summary>
    public class LexicalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LexicalException" /> class.
        /// </summary>
        /// <param name="lexicalError">The lexical error.</param>
        public LexicalException(LexicalError lexicalError)
            : base(lexicalError.GetMessage())
        {
            this.LexicalError = lexicalError;
        }

        /// <summary>
        /// Gets the lexical error.
        /// </summary>
        /// <value>
        /// The lexical error.
        /// </value>
        public LexicalError LexicalError { get; }
    }
}