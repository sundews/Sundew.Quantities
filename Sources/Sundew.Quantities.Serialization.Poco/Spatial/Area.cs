namespace Sundew.Quantities.Serialization.Poco.Spatial
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spatial.Area"/> as a serializable type.
    /// </summary>
    public sealed class Area : SerializableQuantity<Quantities.Spatial.Area>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        public Area()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Area(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instance to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Spatial.Area"/>.</returns>
        public override Quantities.Spatial.Area ToQuantity()
        {
            return new Quantities.Spatial.Area(this.Value, this.GetUnit());
        }
    }
}