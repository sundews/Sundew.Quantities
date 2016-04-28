namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;

    /// <summary>
    /// Abstract base class for various parse exceptions.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public abstract class ParseException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseException" /> class.
        /// </summary>
        /// <param name="error">The parse error.</param>
        protected ParseException(IError error)
            : base(error.GetMessage())
        {
        }
    }
}