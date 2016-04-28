namespace Sundew.Quantities.Serialization.Poco
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Quantity"/> serializable type.
    /// </summary>
    public class Quantity : SerializableQuantity<Sundew.Quantities.Quantity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        public Quantity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Quantity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Quantity" />.
        /// </returns>
        public override Sundew.Quantities.Quantity ToQuantity()
        {
            return new Sundew.Quantities.Quantity(this.Value, this.GetUnit());
        }
    }
}