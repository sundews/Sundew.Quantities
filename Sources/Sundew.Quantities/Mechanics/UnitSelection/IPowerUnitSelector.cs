namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Power"/> unit selector.
    /// </summary>
    public interface IPowerUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the watt.
        /// </summary>
        /// <value>
        /// The watt <see cref="Expression"/>.
        /// </value>
        Expression Watts { get; }
    }
}