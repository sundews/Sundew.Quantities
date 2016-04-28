namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents a capacitance quantity.
    /// </summary>
    public partial class Capacitance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Charge operator *(Capacitance lhs, Potential rhs)
        {
            return new Charge(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}