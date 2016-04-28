namespace Sundew.Quantities.Serialization.Poco.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mechanics.Momentum"/> as a serializable type.
    /// </summary>
    public class Momentum : SerializableQuantity<Quantities.Mechanics.Momentum>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Momentum"/> class.
        /// </summary>
        public Momentum()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Momentum"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Momentum(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Mechanics.Momentum"/>.</returns>
        public override Quantities.Mechanics.Momentum ToQuantity()
        {
            return new Quantities.Mechanics.Momentum(this.Value, this.GetUnit());
        }
    }
}