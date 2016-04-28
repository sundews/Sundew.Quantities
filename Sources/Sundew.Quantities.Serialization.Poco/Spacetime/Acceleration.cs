namespace Sundew.Quantities.Serialization.Poco.Spacetime
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spacetime.Acceleration" /> as a serializable type.
    /// </summary>
    public sealed class Acceleration : SerializableQuantity<Quantities.Spacetime.Acceleration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        public Acceleration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Acceleration(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Spacetime.Acceleration"/>.</returns>
        public override Quantities.Spacetime.Acceleration ToQuantity()
        {
            return new Quantities.Spacetime.Acceleration(this.Value, this.GetUnit());
        }
    }
}