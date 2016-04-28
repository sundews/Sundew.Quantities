namespace Sundew.Quantities.Serialization.Poco.Spacetime
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spacetime.Velocity"/> as a serializable type.
    /// </summary>
    public sealed class Velocity : SerializableQuantity<Quantities.Spacetime.Velocity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity"/> class.
        /// </summary>
        public Velocity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Velocity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Spacetime.Velocity"/>.</returns>
        public override Quantities.Spacetime.Velocity ToQuantity()
        {
            return new Quantities.Spacetime.Velocity(this.Value, this.GetUnit());
        }
    }
}