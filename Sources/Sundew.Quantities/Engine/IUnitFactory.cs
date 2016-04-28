namespace Sundew.Quantities.Engine
{
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    /// <summary>
    /// Interface for implementing a unit factory.
    /// </summary>
    public interface IUnitFactory
    {
        /// <summary>
        /// Creates an unit for the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="IUnit" />.</returns>
        IUnit Create(Expression expression);

        /// <summary>
        /// Creates the derived unit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="DerivedUnit" />.</returns>
        DerivedUnit CreateDerivedUnit(Expression expression);

        /// <summary>
        /// Creates the specified reduction result.
        /// </summary>
        /// <param name="reductionResult">The reduction result.</param>
        /// <returns>A new <see cref="IUnit"/>.</returns>
        IUnit Create(IReductionResult reductionResult);

        /// <summary>
        /// Creates the derived unit.
        /// </summary>
        /// <param name="baseReductionResult">The base reduction result.</param>
        /// <param name="reductionResult">The reduction result.</param>
        /// <returns>A new <see cref="DerivedUnit" />.</returns>
        DerivedUnit CreateDerivedUnit(IReductionResult baseReductionResult, IReductionResult reductionResult);

        /// <summary>
        /// Creates the derived unit.
        /// </summary>
        /// <param name="reductionResult">The reduction result.</param>
        /// <returns>A new <see cref="DerivedUnit" />.</returns>
        DerivedUnit CreateDerivedUnit(IReductionResult reductionResult);

        /// <summary>
        /// Creates the prefixed unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <param name="prefixFactor">The prefix factor.</param>
        /// <returns>A prefixed <see cref="IUnit"/>.</returns>
        IUnit CreatePrefixedUnit(IUnit unit, double prefixFactor);
    }
}