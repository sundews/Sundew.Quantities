namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="MagneticFluxDensity"/> unit selector.
    /// </summary>
    public interface IMagneticFluxDensityUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Tesla.
        /// </summary>
        /// <value>
        /// The Tesla.
        /// </value>
        Expression Teslas { get; }
    }
}