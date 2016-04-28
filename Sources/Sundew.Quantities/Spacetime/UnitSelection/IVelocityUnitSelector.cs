namespace Sundew.Quantities.Spacetime.UnitSelection
{
    using Sundew.Quantities.Periodics.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Velocity"/> unit selector.
    /// </summary>
    public interface IVelocityUnitSelector : IDistanceUnitSelector, ITimeUnitSelector
    {
    }
}