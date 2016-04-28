namespace Sundew.Quantities.Chemistry
{
    using Sundew.Quantities.Chemistry.UnitSelection;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Represents a amount of substance quantity.
    /// </summary>
#pragma warning disable 660, 661
    public sealed partial class AmountOfSubstance : Quantity<AmountOfSubstance, Serialization.AmountOfSubstance, AmountOfSubstanceUnitSelector>
#pragma warning restore 660,661
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountOfSubstance" /> class.
        /// </summary>
        /// <param name="amountOfSubstance">The amountOfSubstance.</param>
        /// <param name="amountOfSubstanceUnitSelector">The AmountOfSubstance unit selector.</param>
        public AmountOfSubstance(double amountOfSubstance, SelectUnit<AmountOfSubstanceUnitSelector> amountOfSubstanceUnitSelector)
            : base(amountOfSubstance, amountOfSubstanceUnitSelector(new AmountOfSubstanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountOfSubstance" /> class.
        /// </summary>
        /// <param name="quantityOperationResult">The quantity operation result.</param>
        public AmountOfSubstance(QuantityOperationResult quantityOperationResult)
            : base(quantityOperationResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountOfSubstance" /> class.
        /// </summary>
        /// <param name="amountOfSubstance">The amountOfSubstance.</param>
        /// <param name="unit">The unit.</param>
        public AmountOfSubstance(double amountOfSubstance, IUnit unit)
            : base(amountOfSubstance, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountOfSubstance" /> class.
        /// </summary>
        /// <param name="amountOfSubstance">The amountOfSubstance.</param>
        public AmountOfSubstance(double amountOfSubstance)
                : this(amountOfSubstance, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Checks if the specified LHS is equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A value indicating whether the lhs is equal to the rhs.</returns>
        public static bool operator ==(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        /// <summary>
        /// Checks if the specified LHS differs from the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A value indicating whether the lhs differs from the rhs.</returns>
        public static bool operator !=(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        /// <summary>
        /// Checks if the specified LHS is greater than or equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A value indicating whether the lhs is greater than or equal to the rhs.</returns>
        public static bool operator >=(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        /// <summary>
        /// Checks if the specified LHS is less than or equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A value indicating whether the lhs is less than or equal to  the rhs.</returns>
        public static bool operator <=(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        /// <summary>
        /// Checks if the specified LHS is greater than to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A value indicating whether the lhs is greater than to the rhs.</returns>
        public static bool operator >(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        /// <summary>
        /// Checks if the specified LHS is less than to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>A value indicating whether the lhs is less than to  the rhs.</returns>
        public static bool operator <(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        /// <summary>
        /// Returns the specified amountOfSubstance.
        /// </summary>
        /// <param name="amountOfSubstance">The amountOfSubstance.</param>
        /// <returns>The same value.</returns>
        public static AmountOfSubstance operator +(AmountOfSubstance amountOfSubstance)
        {
            return amountOfSubstance;
        }

        /// <summary>
        /// Negates the specified amountOfSubstance.
        /// </summary>
        /// <param name="amountOfSubstance">The amountOfSubstance.</param>
        /// <returns>The negated value.</returns>
        public static AmountOfSubstance operator -(AmountOfSubstance amountOfSubstance)
        {
            return amountOfSubstance.CreateQuantity(-amountOfSubstance.Value, amountOfSubstance.Unit);
        }

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static AmountOfSubstance operator ++(AmountOfSubstance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static AmountOfSubstance operator --(AmountOfSubstance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Adds the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The sum.</returns>
        public static AmountOfSubstance operator +(AmountOfSubstance lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value + rhs, lhs.Unit);
        }

        /// <summary>
        /// Subtracts the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The difference.</returns>
        public static AmountOfSubstance operator -(AmountOfSubstance lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value - rhs, lhs.Unit);
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The product.</returns>
        public static AmountOfSubstance operator *(AmountOfSubstance lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value * rhs, lhs.Unit);
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The quotient.</returns>
        public static AmountOfSubstance operator /(AmountOfSubstance lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value / rhs, lhs.Unit);
        }

        /// <summary>
        /// Adds the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The sum.</returns>
        public static AmountOfSubstance operator +(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return lhs.CreateQuantity(QuantityOperations.Add(lhs, rhs));
        }

        /// <summary>
        /// Subtracts the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The difference.</returns>
        public static AmountOfSubstance operator -(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return lhs.CreateQuantity(QuantityOperations.Subtract(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>The quotient.</returns>
        public static double operator /(AmountOfSubstance lhs, AmountOfSubstance rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        /// <summary>
        /// Creates the serializable electric current.
        /// </summary>
        /// <returns>A new serializable AmountOfSubstance.</returns>
        public override Serialization.AmountOfSubstance CreateSerializable()
        {
            return new Serialization.AmountOfSubstance(this);
        }

        /// <summary>
        /// Creates the electric current quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="AmountOfSubstance"/>.</returns>
        public override AmountOfSubstance CreateQuantity(double value, IUnit unit)
        {
            return new AmountOfSubstance(value, unit);
        }

        /// <summary>
        /// Gets the default unit mode.
        /// </summary>
        /// <returns>The value <see cref="UnitFormat.Exact"/>.</returns>
        public override UnitFormat GetDefaultUnitMode()
        {
            return UnitFormat.Exact;
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="AmountOfSubstanceUnitSelector"/>.</returns>
        protected override AmountOfSubstanceUnitSelector CreateUnitSelector()
        {
            return new AmountOfSubstanceUnitSelector();
        }
    }
}
