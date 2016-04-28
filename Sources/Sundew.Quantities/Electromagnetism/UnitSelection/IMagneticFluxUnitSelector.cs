namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="MagneticFlux"/> unit selector.
    /// </summary>
    public interface IMagneticFluxUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Weber.
        /// </summary>
        /// <value>
        /// The Weber.
        /// </value>
        Expression Webers { get; }
    }
}