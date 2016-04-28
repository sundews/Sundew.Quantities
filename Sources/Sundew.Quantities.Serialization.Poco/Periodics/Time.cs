namespace Sundew.Quantities.Serialization.Poco.Periodics
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Quantities.Periodics.Time"/> as a serializable type.
    /// </summary>
    public sealed class Time : SerializableQuantity<Quantities.Periodics.Time>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Time(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Quantities.Periodics.Time"/>.</returns>
        public override Quantities.Periodics.Time ToQuantity()
        {
            return new Quantities.Periodics.Time(this.Value, this.GetUnit());
        }
    }
}