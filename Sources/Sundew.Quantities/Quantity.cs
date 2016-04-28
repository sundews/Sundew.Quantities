namespace Sundew.Quantities
{
    using System.Globalization;

    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Custom quantity.
    /// </summary>
    public sealed class Quantity : Quantity<Quantity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Quantity(IQuantity quantity)
            : base(quantity.Value, quantity.Unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        public Quantity(double value, IUnit unit)
            : base(value, unit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Quantity"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Quantity Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Quantity operator ++(Quantity lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Quantity operator --(Quantity lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Multiplies the specified LHS with the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A <see cref="Quantity"/>.</returns>
        public static Quantity operator *(Quantity lhs, Quantity rhs)
        {
            return lhs.CreateQuantity(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS with the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A <see cref="Quantity"/>.</returns>
        public static Quantity operator /(Quantity lhs, Quantity rhs)
        {
            return lhs.CreateQuantity(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Parses the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="cultureInfo">The culture information.</param>
        /// <returns>The parsed <see cref="Quantity" />.</returns>
        public static Quantity Parse(string quantity, CultureInfo cultureInfo = null)
        {
            return UnitSystem.GetQuantityFrom(quantity, cultureInfo ?? CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Creates the quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="Quantity"/>.</returns>
        public override Quantity CreateQuantity(double value, IUnit unit)
        {
            return new Quantity(value, unit);
        }
    }
}