namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for implementing prefixed volume selector.
    /// </summary>
    public interface IPrefixedVolumeSelector : IVolumeUnitSelector, IPrefixSelector<IVolumeUnitSelector>
    {
    }
}