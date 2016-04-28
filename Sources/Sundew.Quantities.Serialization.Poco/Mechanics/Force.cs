namespace Sundew.Quantities.Serialization.Poco.Mechanics
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mechanics.Force"/> as a serializable type.
    /// </summary>
    public class Force : SerializableQuantity<Quantities.Mechanics.Force>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Force"/> class.
        /// </summary>
        public Force()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Force" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Force(IQuantity quantity)
                    : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A new <see cref="Force"/>.</returns>
        public override Quantities.Mechanics.Force ToQuantity()
        {
            return new Quantities.Mechanics.Force(this.Value, this.GetUnit());
        }
    }
}