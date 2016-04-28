namespace Sundew.Quantities.Spacetime.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Velocity"/> unit selector.
    /// </summary>
    public interface IPrefixedVelocityUnitSelector : IVelocityUnitSelector, IPrefixSelector<IVelocityUnitSelector>
    {
    }
}