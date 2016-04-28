namespace Sundew.Quantities.Serialization.Poco.Thermodynamics
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Thermodynamics.Temperature"/> as a serializable type.
    /// </summary>
    public class Temperature : SerializableQuantity<Quantities.Thermodynamics.Temperature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        public Temperature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Temperature(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Thermodynamics.Temperature" />.
        /// </returns>
        public override Quantities.Thermodynamics.Temperature ToQuantity()
        {
            return new Quantities.Thermodynamics.Temperature(this.Value, this.GetUnit());
        }
    }
}