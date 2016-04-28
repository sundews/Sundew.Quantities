namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Potential"/> unit selector.
    /// </summary>
    public interface IPotentialUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <value>
        /// The volt <see cref="Expression"/>.
        /// </value>
        Expression Volts { get; }
    }
}