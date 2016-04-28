namespace Sundew.Quantities.Serialization.Poco.Spatial
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spatial.SolidAngle"/> as a serializable type.
    /// </summary>
    public class SolidAngle : SerializableQuantity<Quantities.Spatial.SolidAngle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle"/> class.
        /// </summary>
        public SolidAngle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public SolidAngle(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Spatial.SolidAngle" />.
        /// </returns>
        public override Quantities.Spatial.SolidAngle ToQuantity()
        {
            return new Quantities.Spatial.SolidAngle(this.Value, this.GetUnit());
        }
    }
}