namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.Capacitance"/> as a serializable type.
    /// </summary>
    public class Capacitance : SerializableQuantity<Quantities.Electromagnetism.Capacitance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capacitance"/> class.
        /// </summary>
        public Capacitance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capacitance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Capacitance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Electromagnetism.Capacitance" />.
        /// </returns>
        public override Quantities.Electromagnetism.Capacitance ToQuantity()
        {
            return new Quantities.Electromagnetism.Capacitance(this.Value, this.GetUnit());
        }
    }
}