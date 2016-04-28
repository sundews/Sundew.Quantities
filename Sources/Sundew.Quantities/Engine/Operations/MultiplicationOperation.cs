namespace Sundew.Quantities.Engine.Operations
{
    /// <summary>
    /// Operation for multiplying two values.
    /// </summary>
    public class MultiplicationOperation : IDoubleOperation
    {
        /// <summary>
        /// Multiplies the specified values.
        /// </summary>
        /// <param name="lhs">The LHS value.</param>
        /// <param name="rhs">The RHS value.</param>
        /// <returns>The multiplication result.</returns>
        public double Execute(double lhs, double rhs)
        {
            return lhs * rhs;
        }
    }
}