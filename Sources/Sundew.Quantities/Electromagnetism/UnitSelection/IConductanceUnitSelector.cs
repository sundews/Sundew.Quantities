namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Conductance"/> unit selector.
    /// </summary>
    public interface IConductanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the siemens.
        /// </summary>
        /// <value>
        /// The siemens.
        /// </value>
        Expression Siemens { get; }
    }
}