namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    /// <summary>
    /// Specifies the operation order format.
    /// </summary>
    public enum OperationOrderFormat
    {
        /// <summary>
        /// No operation order will be shown.
        /// </summary>
        None,

        /// <summary>
        /// Curly Brackets will indicate precedence.
        /// </summary>
        CurlyBrackets,

        /// <summary>
        /// Parentheses will indicate the order.
        /// </summary>
        Parentheses,
    }
}