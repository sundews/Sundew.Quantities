// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Quantity{TQuantity,TSerializable}.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Quantities
{
    using System;
    using System.Globalization;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Abstract base class for implementing <see cref="IQuantity{TQuantity}" />.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public abstract class Quantity<TQuantity> : IQuantity<TQuantity>, IUnitConvertible<TQuantity>
        where TQuantity : IQuantity<TQuantity>, IDeferredQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity{TQuantity}"/> class.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        protected Quantity(double value, IUnit unit)
        {
            this.Value = value;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets this instance as <see cref="TQuantity"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected abstract TQuantity Self { get; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The quantity value.
        /// </value>
        public double Value { get; }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <value>
        /// The quantity unit.
        /// </value>
        public IUnit Unit { get; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>
        /// A <see cref="IQuantity{TQuantity}" />.
        /// </returns>
        public IQuantity GetResult()
        {
            return this;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider formatProvider)
        {
            return this.ToString(null, formatProvider);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit mode.</param>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat, string format)
        {
            return this.ToString(unitFormat, format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit mode.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat, IFormatProvider formatProvider)
        {
            return this.ToString(unitFormat, null, formatProvider);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString(UnitFormat.Default, format, formatProvider);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit mode.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat, string format, IFormatProvider formatProvider)
        {
            return QuantityHelper.ToString(
                this.Unit.FormatValue(this.Value, format, formatProvider),
                UnitHelper.GetNotation(this.Unit, unitFormat));
        }

        /// <summary>
        /// Determines whether the specified quantity is equal to this instance.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(IQuantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Exponent Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows <paramref name="obj" /> in the sort order.
        /// </returns>
        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<IQuantity>(this, obj);
        }

        /// <summary>
        /// Compares the quantity to this instance.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// The result of <see cref="double" /> Compare based the rhs converted to the same unit as lhs.
        /// </returns>
        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        /// <summary>
        /// Converts this object to a <see cref="double"/> using the specified unit.
        /// </summary>
        /// <param name="unit">The new unit.</param>
        /// <returns>The converted <see cref="double"/>.</returns>
        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        /// <summary>
        /// Converts this object to a <see cref="IQuantity" /> using the unit specified by the <see cref="IUnit" />.
        /// </summary>
        /// <param name="unit">The target unit.</param>
        /// <returns>
        /// The resulting <see cref="IQuantity" />.
        /// </returns>
        IQuantity IUnitConvertible.ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        /// <summary>
        /// Creates a new quantity.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>
        /// A new <see cref="TQuantity" />.
        /// </returns>
        public abstract TQuantity CreateQuantity(double value, IUnit unit);

        /// <summary>
        /// Converts this object to a <see cref="TQuantity"/> using the specified unit.
        /// </summary>
        /// <param name="unit">The new unit.</param>
        /// <returns>The converted <see cref="TQuantity"/>.</returns>
        public TQuantity ToUnit(IUnit unit)
        {
            return this.CreateQuantity(this.ToDouble(unit), unit);
        }

        /// <summary>
        /// Checks if the specified LHS is equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs is equal to the rhs.</returns>
        public static bool operator ==(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        /// <summary>
        /// Checks if the specified LHS differs from the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs differs from the rhs.</returns>
        public static bool operator !=(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        /// <summary>
        /// Checks if the specified LHS is greater than or equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs is greater than or equal to the rhs.</returns>
        public static bool operator >=(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        /// <summary>
        /// Checks if the specified LHS is less than or equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs is less than or equal to  the rhs.</returns>
        public static bool operator <=(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        /// <summary>
        /// Checks if the specified LHS is greater than to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs is greater than to the rhs.</returns>
        public static bool operator >(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        /// <summary>
        /// Checks if the specified LHS is less than to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs is less than to  the rhs.</returns>
        public static bool operator <(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        /// <summary>
        /// Returns the specified temperature.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>The same value.</returns>
        public static TQuantity operator +(Quantity<TQuantity> quantity)
        {
            return quantity.Self;
        }

        /// <summary>
        /// Negates the specified temperature.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>The negated value.</returns>
        public static TQuantity operator -(Quantity<TQuantity> quantity)
        {
            return quantity.CreateQuantity(-quantity.Value, quantity.Unit);
        }

        /// <summary>
        /// Adds the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The sum of the LHS and RHS.</returns>
        public static TQuantity operator +(Quantity<TQuantity> lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value + rhs, lhs.Unit);
        }

        /// <summary>
        /// Subtracts the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The difference.</returns>
        public static TQuantity operator -(Quantity<TQuantity> lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value - rhs, lhs.Unit);
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product.</returns>
        public static TQuantity operator *(Quantity<TQuantity> lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value * rhs, lhs.Unit);
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient.</returns>
        public static TQuantity operator /(Quantity<TQuantity> lhs, double rhs)
        {
            return lhs.CreateQuantity(lhs.Value / rhs, lhs.Unit);
        }

        /// <summary>
        /// Adds the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The sum of the LHS and RHS.</returns>
        public static TQuantity operator +(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return lhs.CreateQuantity(QuantityOperations.Add(lhs, rhs));
        }

        /// <summary>
        /// Subtracts the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The difference.</returns>
        public static TQuantity operator -(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return lhs.CreateQuantity(QuantityOperations.Subtract(lhs, rhs));
        }

        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product.</returns>
        public static Product<TQuantity, TQuantity> operator *(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return new Product<TQuantity, TQuantity>(lhs.Self, rhs.Self);
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient.</returns>
        public static double operator /(Quantity<TQuantity> lhs, Quantity<TQuantity> rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        /// <summary>
        /// Squares this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="Squared{TQuantity}"/>.
        /// </returns>
        public Squared<TQuantity> Squared()
        {
            return new Squared<TQuantity>(this.Self);
        }

        /// <summary>
        /// Cubes this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="Cubed{TQuantity}"/>.
        /// </returns>
        public Cubed<TQuantity> Cubed()
        {
            return new Cubed<TQuantity>(this.Self);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit mode.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat)
        {
            return this.ToString(unitFormat, null, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Checks if this instance is equal to the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// A value indication whether the lhs and the rhs are equal.
        /// </returns>
        public bool Equals(TQuantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return QuantityHelper.AreEqual(this, obj);
        }

        /// <summary>
        /// Compares this instance the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>The result of <see cref="int"/> Compare based the rhs converted to the same unit as lhs.</returns>
        public int CompareTo(TQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return QuantityHelper.GetHashCode(this);
        }

        /// <summary>
        /// Converts this object to a <see cref="TQuantity" /> using the specified unit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>
        /// The converted <see cref="TQuantity" />.
        /// </returns>
        protected TQuantity ToUnit(Expression expression)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(expression));
        }

        /// <summary>
        /// Converts this object to a <see cref="double" /> using the specified unit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>
        /// The converted <see cref="double" />.
        /// </returns>
        protected double ToDouble(Expression expression)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(expression));
        }
    }
}