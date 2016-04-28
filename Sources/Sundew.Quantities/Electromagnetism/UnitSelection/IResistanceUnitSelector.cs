namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Resistance"/> unit selector.
    /// </summary>
    public interface IResistanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the ohm.
        /// </summary>
        /// <value>
        /// The ohm <see cref="Expression"/>.
        /// </value>
        Expression Ohms { get; }
    }
}