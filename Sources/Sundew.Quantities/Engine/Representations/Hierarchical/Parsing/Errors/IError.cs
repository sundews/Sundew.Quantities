namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors
{
    /// <summary>
    /// Interface for representing an error.
    /// </summary>
    public interface IError
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <returns>The error message.</returns>
        string GetMessage();
    }
}