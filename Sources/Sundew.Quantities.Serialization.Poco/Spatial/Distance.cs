namespace Sundew.Quantities.Serialization.Poco.Spatial
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Spatial.Distance" /> as a serializable type.
    /// </summary>
    public sealed class Distance : SerializableQuantity<Quantities.Spatial.Distance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        public Distance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Distance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Spatial.Distance"/>.</returns>
        public override Quantities.Spatial.Distance ToQuantity()
        {
            return new Quantities.Spatial.Distance(this.Value, this.GetUnit());
        }
    }
}