namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.Charge"/> as a serializable type.
    /// </summary>
    public class Charge : SerializableQuantity<Quantities.Electromagnetism.Charge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge"/> class.
        /// </summary>
        public Charge()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Charge(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable charge to a quantity charge.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Electromagnetism.Charge"/>.</returns>
        public override Quantities.Electromagnetism.Charge ToQuantity()
        {
            return new Quantities.Electromagnetism.Charge(this.Value, this.GetUnit());
        }
    }
}