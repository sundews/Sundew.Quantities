namespace Sundew.Quantities.Photometry.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="LuminousFlux"/> unit selector.
    /// </summary>
    public interface ILuminousFluxUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the lumen.
        /// </summary>
        /// <value>
        /// The lumen.
        /// </value>
        Expression Lumens { get; }
    }
}