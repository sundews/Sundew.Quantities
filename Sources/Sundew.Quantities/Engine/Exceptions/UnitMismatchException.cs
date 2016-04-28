namespace Sundew.Quantities.Engine.Exceptions
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Thrown when attempting an operation between two incompatible units.
    /// </summary>
    public class UnitMismatchException : Exception
    {
        private const string TheFollowingOperationForTheLhsUnitAndTheRhsUnitIsInvalid = "The following operation: {0} for the lhs unit {1} and the rhs unit {2} is invalid";

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitMismatchException" /> class.
        /// </summary>
        /// <param name="operationType">The operation type.</param>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        public UnitMismatchException(OperationType operationType, IUnit lhs, IUnit rhs)
            : base(string.Format(TheFollowingOperationForTheLhsUnitAndTheRhsUnitIsInvalid, operationType, lhs, rhs))
        {
            this.OperationType = operationType;
        }

        /// <summary>
        /// Gets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public OperationType OperationType { get; }
    }
}