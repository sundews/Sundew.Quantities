namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using System.Linq.Expressions;

    /// <summary>
    /// Contains default visitors used for <see cref="Expression"/>s.
    /// </summary>
    public static class DefaultVisitors
    {
        /// <summary>
        /// To base visitor.
        /// </summary>
        public static readonly ValueToBaseVisitor ValueToBaseVisitor = new ValueToBaseVisitor();

        /// <summary>
        /// From base visitor.
        /// </summary>
        public static readonly ValueFromBaseVisitor ValueFromBaseVisitor = new ValueFromBaseVisitor();

        /// <summary>
        /// The prefix visitor.
        /// </summary>
        public static readonly PrefixVisitor PrefixVisitor = new PrefixVisitor();

        /// <summary>
        /// The notation visitor.
        /// </summary>
        public static readonly NotationVisitor NotationVisitor = new NotationVisitor(NotationOptions.Default);

        /// <summary>
        /// The base expression visitor.
        /// </summary>
        public static readonly BaseExpressionVisitor BaseExpressionVisitor = new BaseExpressionVisitor();
    }
}