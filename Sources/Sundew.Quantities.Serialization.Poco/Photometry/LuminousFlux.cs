namespace Sundew.Quantities.Serialization.Poco.Photometry
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Photometry.LuminousFlux"/> as a serializable type.
    /// </summary>
    public class LuminousFlux : SerializableQuantity<Quantities.Photometry.LuminousFlux>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        public LuminousFlux()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public LuminousFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Photometry.LuminousFlux"/>.
        /// </returns>
        public override Quantities.Photometry.LuminousFlux ToQuantity()
        {
            return new Quantities.Photometry.LuminousFlux(this.Value, this.GetUnit());
        }
    }
}