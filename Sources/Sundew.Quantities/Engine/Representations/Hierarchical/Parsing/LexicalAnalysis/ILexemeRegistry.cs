namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    /// <summary>
    /// Interface for implementing a lexeme registry.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface ILexemeRegistry<TResult>
    {
        /// <summary>
        /// Tries to get the result.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="result">The found result.</param>
        /// <returns><c>true</c> if the input is found, otherwise <c>false</c> </returns>
        bool TryGet(string input, out TResult result);
    }
}