namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.MagneticFlux"/> as a serializable type.
    /// </summary>
    public class MagneticFlux : SerializableQuantity<Quantities.Electromagnetism.MagneticFlux>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux"/> class.
        /// </summary>
        public MagneticFlux()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public MagneticFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Electromagnetism.MagneticFlux" />.
        /// </returns>
        public override Quantities.Electromagnetism.MagneticFlux ToQuantity()
        {
            return new Quantities.Electromagnetism.MagneticFlux(this.Value, this.GetUnit());
        }
    }
}