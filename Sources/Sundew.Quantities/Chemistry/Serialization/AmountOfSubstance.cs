namespace Sundew.Quantities.Chemistry.Serialization
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Serialization;

    /// <summary>
    /// Represents <see cref="Chemistry.AmountOfSubstance"/> as a serializable type.
    /// </summary>
    public class AmountOfSubstance : SerializableQuantity<Chemistry.AmountOfSubstance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountOfSubstance"/> class.
        /// </summary>
        public AmountOfSubstance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountOfSubstance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public AmountOfSubstance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Chemistry.AmountOfSubstance" />.
        /// </returns>
        public override Chemistry.AmountOfSubstance ToQuantity()
        {
            return new Chemistry.AmountOfSubstance(this.Value, UnitSystem.Get(this.Unit));
        }
    }
}