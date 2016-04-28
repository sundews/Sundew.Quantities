namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Periodics.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Charge"/> unit selector.
    /// </summary>
    public interface IChargeUnitSelector : IElectricCurrentUnitSelector, ITimeUnitSelector
    {
        /// <summary>
        /// Gets the coulomb.
        /// </summary>
        /// <value>
        /// The coulomb.
        /// </value>
        Expression Coulombs { get; }
    }
}