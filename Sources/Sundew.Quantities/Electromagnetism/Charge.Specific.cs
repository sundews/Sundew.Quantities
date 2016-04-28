namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents a charge quantity.
    /// </summary>
    public partial class Charge
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The <see cref="Energy"/>.</returns>
        public static Energy operator *(Charge lhs, Potential rhs)
        {
            return new Energy(QuantityOperations.Multiply(lhs, rhs));
        }
        
        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The <see cref="ElectricCurrent"/>.</returns>
        public static ElectricCurrent operator /(Charge lhs, Time rhs)
        {
            return new ElectricCurrent(QuantityOperations.Divide(lhs, rhs));
        }
    }
}