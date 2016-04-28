namespace Sundew.Quantities.Spacetime.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Acceleration"/> unit selector.
    /// </summary>
    public interface IPrefixedAccelerationUnitSelector : IAccelerationUnitSelector, IPrefixSelector<IAccelerationUnitSelector>
    {
    }
}