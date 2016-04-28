namespace Sundew.Quantities.Serialization.Poco.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Electromagnetism.ElectricCurrent"/> as a serializable type.
    /// </summary>
    public class ElectricCurrent : SerializableQuantity<Quantities.Electromagnetism.ElectricCurrent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent"/> class.
        /// </summary>
        public ElectricCurrent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public ElectricCurrent(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable electric current to a quantity electric current.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Electromagnetism.ElectricCurrent"/>.</returns>
        public override Quantities.Electromagnetism.ElectricCurrent ToQuantity()
        {
            return new Quantities.Electromagnetism.ElectricCurrent(this.Value, this.GetUnit());
        }
    }
}