namespace Sundew.Quantities.Serialization.Poco.Mechanics
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Mechanics.Pressure"/> as a serializable type.
    /// </summary>
    public class Pressure : SerializableQuantity<Quantities.Mechanics.Pressure>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure"/> class.
        /// </summary>
        public Pressure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Pressure(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Mechanics.Pressure"/>.</returns>
        public override Quantities.Mechanics.Pressure ToQuantity()
        {
            return new Quantities.Mechanics.Pressure(this.Value, this.GetUnit());
        }
    }
}