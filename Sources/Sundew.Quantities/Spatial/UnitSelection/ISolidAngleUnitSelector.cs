namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Spatial.SolidAngle"/> unit selector.
    /// </summary>
    public interface ISolidAngleUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the steradian.
        /// </summary>
        /// <value>
        /// The steradian.
        /// </value>
        Expression Steradians { get; }
    }
}