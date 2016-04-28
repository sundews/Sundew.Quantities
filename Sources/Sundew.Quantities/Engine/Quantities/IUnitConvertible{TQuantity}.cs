namespace Sundew.Quantities.Engine.Quantities
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing unit conversion methods.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public interface IUnitConvertible<out TQuantity> : IUnitConvertible
    {
        /// <summary>
        /// Converts this object to a <see cref="TQuantity"/> using the specified unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>The converted <see cref="TQuantity"/>.</returns>
        TQuantity ToUnit(IUnit unit);
    }
}