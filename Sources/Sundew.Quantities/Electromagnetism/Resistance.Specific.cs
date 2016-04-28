namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents a resistance quantity.
    /// </summary>
    public partial class Resistance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Potential operator *(Resistance lhs, ElectricCurrent rhs)
        {
            return new Potential(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Inductance operator *(Resistance lhs, Time rhs)
        {
            return new Inductance(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}