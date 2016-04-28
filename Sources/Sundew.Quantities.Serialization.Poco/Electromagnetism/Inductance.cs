namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.Inductance"/> as a serializable type.
    /// </summary>
    public class Inductance : SerializableQuantity<Quantities.Electromagnetism.Inductance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inductance"/> class.
        /// </summary>
        public Inductance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inductance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Inductance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Electromagnetism.Inductance" />.
        /// </returns>
        public override Quantities.Electromagnetism.Inductance ToQuantity()
        {
            return new Quantities.Electromagnetism.Inductance(this.Value, this.GetUnit());
        }
    }
}