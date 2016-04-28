namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Unit selector for volume.
    /// </summary>
    public interface IVolumeUnitSelector : IDistanceUnitSelector
    {
        /// <summary>
        /// Gets the liter.
        /// </summary>
        /// <value>The liter <see cref="Expression"/>.</value>
        Expression Liters { get; }
    }
}