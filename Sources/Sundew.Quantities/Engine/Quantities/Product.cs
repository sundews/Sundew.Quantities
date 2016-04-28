namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Represents the product of two serializable <see cref="IDeferredQuantity"/>s.
    /// </summary>
    /// <typeparam name="TMultiplier">The type of the multiplier quantity.</typeparam>
    /// <typeparam name="TMultiplicand">The type of the multiplicand quantity.</typeparam>
    public class Product<TMultiplier, TMultiplicand> : IDeferredQuantity
        where TMultiplier : IDeferredQuantity
        where TMultiplicand : IDeferredQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product{TMultiplier, TMultiplicand}" /> class.
        /// </summary>
        /// <param name="multiplier">The multiplier.</param>
        /// <param name="multiplicand">The multiplicand.</param>
        public Product(TMultiplier multiplier, TMultiplicand multiplicand)
        {
            this.Multiplier = multiplier;
            this.Multiplicand = multiplicand;
        }

        /// <summary>
        /// Gets the multiplier.
        /// </summary>
        /// <value>
        /// The multiplier.
        /// </value>
        public TMultiplier Multiplier { get; }

        /// <summary>
        /// Gets the multiplicand.
        /// </summary>
        /// <value>
        /// The multiplicand.
        /// </value>
        public TMultiplicand Multiplicand { get; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>A <see cref="IQuantity{TQuantity}"/>.</returns>
        public IQuantity GetResult()
        {
            return QuantityOperations.Multiply(this.Multiplier.GetResult(), this.Multiplicand.GetResult());
        }
    }
}