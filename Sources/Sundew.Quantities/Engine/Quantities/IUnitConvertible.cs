namespace Sundew.Quantities.Engine.Quantities
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing unit conversion method to double.
    /// </summary>
    public interface IUnitConvertible
    {
        /// <summary>
        /// Converts this object to a <see cref="double"/> using the specified unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>The converted <see cref="double"/>.</returns>
        double ToDouble(IUnit unit);

        /// <summary>
        /// Converts this object to a <see cref="IQuantity"/> using the unit specified by the <see cref="IUnit"/>.
        /// </summary>
        /// <param name="unit">The target unit.</param>
        /// <returns>The resulting <see cref="IQuantity"/>.</returns>
        IQuantity ToQuantity(IUnit unit);
    }
}