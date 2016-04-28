namespace Sundew.Quantities.Engine.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing an order of magnitude selector.
    /// </summary>
    /// <typeparam name="TUnitSelector">The type of the derived units.</typeparam>
    public interface IExponentSelector<out TUnitSelector>
    {
        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <value>
        /// The square.
        /// </value>
        TUnitSelector Square { get; }

        /// <summary>
        /// Gets the cubic.
        /// </summary>
        /// <value>
        /// The cubic.
        /// </value>
        TUnitSelector Cubic { get; }

        /// <summary>
        /// Gets the quartic.
        /// </summary>
        /// <value>
        /// The quartic.
        /// </value>
        TUnitSelector Quartic { get; }

        /// <summary>
        /// Gets the quintic.
        /// </summary>
        /// <value>
        /// The quintic.
        /// </value>
        TUnitSelector Quintic { get; }

        /// <summary>
        /// Wraps the the specified expression in a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="ParenthesisExpression"/>.</returns>
        ParenthesisExpression P(Expression expression);
    }
}