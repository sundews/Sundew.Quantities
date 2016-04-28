namespace Sundew.Quantities.Serialization.Poco.Mechanics
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mechanics.Power"/> as a serializable type.
    /// </summary>
    public class Power : SerializableQuantity<Quantities.Mechanics.Power>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        public Power()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Power(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Mechanics.Power"/>.</returns>
        public override Quantities.Mechanics.Power ToQuantity()
        {
            return new Quantities.Mechanics.Power(this.Value, this.GetUnit());
        }
    }
}