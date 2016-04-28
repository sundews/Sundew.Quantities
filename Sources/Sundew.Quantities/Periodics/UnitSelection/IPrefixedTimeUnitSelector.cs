namespace Sundew.Quantities.Periodics.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Time"/> unit selector.
    /// </summary>
    public interface IPrefixedTimeUnitSelector : ITimeUnitSelector, IPrefixSelector<ITimeUnitSelector>
    {
    }
}