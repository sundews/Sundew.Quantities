namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    /// <summary>
    /// Settings for lexical analysis.
    /// </summary>
    public class AnalysisSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisSettings"/> class.
        /// </summary>
        /// <param name="thrownOnError">If set to <c>true</c> [thrown on error].</param>
        public AnalysisSettings(bool thrownOnError)
        {
            this.ThrownOnError = thrownOnError;
        }

        /// <summary>
        /// Gets a value indicating whether an exception should be thrown on error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if an exception should be thrown on error; otherwise, <c>false</c>.
        /// </value>
        public bool ThrownOnError { get; }
    }
}