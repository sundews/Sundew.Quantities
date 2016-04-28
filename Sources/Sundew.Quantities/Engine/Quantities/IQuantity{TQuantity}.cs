namespace Sundew.Quantities.Engine.Quantities
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing strongly typed quantities.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public interface IQuantity<out TQuantity> : IQuantity
    {
        /// <summary>
        /// Creates the quantity.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>A <see cref="TQuantity"/>.</returns>
        TQuantity CreateQuantity(double value, IUnit unit);
    }
}