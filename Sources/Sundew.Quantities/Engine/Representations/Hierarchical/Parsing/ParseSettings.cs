namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing
{
    using System.Globalization;

    /// <summary>
    /// Parameter class for specifying parse settings.
    /// </summary>
    public class ParseSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseSettings"/> class.
        /// </summary>
        /// <param name="cultureInfo">The culture information.</param>
        /// <param name="assertEnd">if set to <c>true</c> [assert end].</param>
        /// <param name="throwOnError">if set to <c>true</c> [throw on error].</param>
        public ParseSettings(CultureInfo cultureInfo, bool assertEnd, bool throwOnError)
        {
            this.CultureInfo = cultureInfo;
            this.AssertEnd = assertEnd;
            this.ThrowOnError = throwOnError;
        }

        /// <summary>
        /// Gets the default.
        /// </summary>
        /// <value>
        /// The default.
        /// </value>
        public static ParseSettings DefaultInvariantCulture { get; } = new ParseSettings(CultureInfo.InvariantCulture, true, true);

        /// <summary>
        /// Gets the default current culture.
        /// </summary>
        /// <value>
        /// The default current culture.
        /// </value>
        public static ParseSettings DefaultCurrentCulture { get; } = new ParseSettings(CultureInfo.CurrentCulture, true, true);

        /// <summary>
        /// Gets the culture information.
        /// </summary>
        /// <value>
        /// The culture information.
        /// </value>
        public CultureInfo CultureInfo { get; }

        /// <summary>
        /// Gets a value indicating whether parsing should assert the ending.
        /// </summary>
        /// <value>
        ///  <c>true</c> if parse should assert the ending; otherwise, <c>false</c>.
        /// </value>
        public bool AssertEnd { get; }

        /// <summary>
        /// Gets a value indicating whether parsing should throw an expcetion on error.
        /// </summary>
        /// <value>
        ///  <c>true</c> if an exception should be thrown; otherwise, <c>false</c>.
        /// </value>
        public bool ThrowOnError { get; }
    }
}