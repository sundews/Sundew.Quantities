namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.ElectricCurrent"/> as a serializable type.
    /// </summary>
    public class Conductance : SerializableQuantity<Quantities.Electromagnetism.Conductance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance"/> class.
        /// </summary>
        public Conductance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Conductance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable electric current to a <see cref="Sundew.Quantities.Electromagnetism.Conductance"/>.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Electromagnetism.Conductance"/>.</returns>
        public override Quantities.Electromagnetism.Conductance ToQuantity()
        {
            return new Quantities.Electromagnetism.Conductance(this.Value, this.GetUnit());
        }
    }
}