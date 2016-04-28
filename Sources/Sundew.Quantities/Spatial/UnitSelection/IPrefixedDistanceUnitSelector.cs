namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Distance"/> unit selector.
    /// </summary>
    public interface IPrefixedDistanceUnitSelector : IPrefixSelector<IDistanceUnitSelector>, IDistanceUnitSelector
    {
    }
}