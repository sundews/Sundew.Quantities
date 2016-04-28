namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Interface for implementing compositions of quantities.
    /// </summary>
    public interface IDeferredQuantity
    {
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>An <see cref="IQuantity"/>.</returns>
        IQuantity GetResult();
    }
}