namespace Sundew.Quantities.Chemistry.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="AmountOfSubstance"/> unit selector.
    /// </summary>
    public interface IAmountOfSubstanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the mole.
        /// </summary>
        /// <value>
        /// The mole.
        /// </value>
        Expression Mole { get; }
    }
}