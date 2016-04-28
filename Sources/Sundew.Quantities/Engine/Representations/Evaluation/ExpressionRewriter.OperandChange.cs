namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using System;

    /// <summary>
    /// The reduction visitor.
    /// </summary>
    public partial class ExpressionRewriter
    {
        [Flags]
        private enum OperandChange
        {
            /// <summary>
            /// The no change.
            /// </summary>
            NoChange = 0,

            /// <summary>
            /// The lhs is null.
            /// </summary>
            LhsIsNull = 1,

            /// <summary>
            /// The rhs is null.
            /// </summary>
            RhsIsNull = 2,

            /// <summary>
            /// The both are null.
            /// </summary>
            BothAreNull = 3,
        }
    }
}