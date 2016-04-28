namespace Sundew.Quantities.Engine.Representations.Hierarchical.Expressions
{
    /// <summary>
    /// Interface for <see cref="Expression"/> with a lhs and a rhs.
    /// </summary>
    /// <typeparam name="TObject">The type of the object.</typeparam>
    public interface IHaveLhsAndRhs<out TObject>
    {
        /// <summary>
        /// Gets the LHS.
        /// </summary>
        /// <value>
        /// The LHS  <see cref="TObject"/>.
        /// </value>
        TObject Lhs { get; }

        /// <summary>
        /// Gets the RHS.
        /// </summary>
        /// <value>
        /// The RHS  <see cref="TObject"/>.
        /// </value>
        TObject Rhs { get; }
    }
}