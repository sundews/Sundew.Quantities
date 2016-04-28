namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Inductance"/> unit selector.
    /// </summary>
    public interface IInductanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Henry.
        /// </summary>
        /// <value>
        /// The Henry.
        /// </value>
        Expression Henry { get; }
    }
}