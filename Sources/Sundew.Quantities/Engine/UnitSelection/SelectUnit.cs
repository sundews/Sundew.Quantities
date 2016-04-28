namespace Sundew.Quantities.Engine.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Delegate for selecting a unit.
    /// </summary>
    /// <typeparam name="TUnits">The type of the units.</typeparam>
    /// <param name="units">The units.</param>
    /// <returns>An <see cref="Expression"/>.</returns>
    public delegate Expression SelectUnit<in TUnits>(TUnits units);
}