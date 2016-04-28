namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Force"/> unit selector.
    /// </summary>
    public interface IForceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Newton.
        /// </summary>
        /// <value>
        /// The Newton.
        /// </value>
        Expression Newtons { get; }
    }
}