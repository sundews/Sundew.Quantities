// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quantity.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using System;
    using System.Globalization;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Custom quantity.
    /// </summary>
    public struct Quantity : IQuantity
    {
        private readonly double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity" /> struct.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Quantity(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity" /> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        public Quantity(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Quantity operator +(Quantity quantity)
        {
            return quantity;
        }

        public static Quantity operator -(Quantity quantity)
        {
            return new Quantity(-quantity.value, quantity.Unit);
        }

        public static Quantity operator ++(Quantity quantity)
        {
            return new Quantity(quantity.value + 1, quantity.Unit);
        }

        public static Quantity operator --(Quantity quantity)
        {
            return new Quantity(quantity.value - 1, quantity.Unit);
        }

        public static Quantity operator +(Quantity lhs, double rhs)
        {
            return new Quantity(lhs.value + rhs, lhs.Unit);
        }

        public static Quantity operator -(Quantity lhs, double rhs)
        {
            return new Quantity(lhs.value - rhs, lhs.Unit);
        }

        public static Quantity operator *(Quantity lhs, double rhs)
        {
            return new Quantity(lhs.value * rhs, lhs.Unit);
        }

        public static Quantity operator /(Quantity lhs, double rhs)
        {
            return new Quantity(lhs.value / rhs, lhs.Unit);
        }

        public static Quantity operator +(Quantity lhs, Quantity rhs)
        {
            return new Quantity(QuantityOperations.Add(lhs, rhs));
        }

        public static Quantity operator -(Quantity lhs, Quantity rhs)
        {
            return new Quantity(QuantityOperations.Subtract(lhs, rhs));
        }

        public static Quantity operator *(Quantity lhs, Quantity rhs)
        {
            return new Quantity(QuantityOperations.Multiply(lhs, rhs));
        }

        public static double operator /(Quantity lhs, Quantity rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Quantity lhs, Quantity rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Quantity lhs, Quantity rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Quantity lhs, Quantity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Quantity lhs, Quantity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Quantity lhs, Quantity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Quantity lhs, Quantity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public Squared<Quantity> Squared()
        {
            return new Squared<Quantity>(this);
        }

        public Cubed<Quantity> Cubed()
        {
            return new Cubed<Quantity>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Quantity ToUnit(IUnit unit)
        {
            return new Quantity(this.ToDouble(unit), unit);
        }

        public override int GetHashCode()
        {
            return QuantityHelper.GetHashCode(this);
        }

        public override bool Equals(object obj)
        {
            return QuantityHelper.AreEqual(this, obj);
        }

        public bool Equals(IQuantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public bool Equals(Quantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Quantity>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Quantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public override string ToString()
        {
            return this.ToString(CultureInfo.CurrentCulture);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        public string ToString(UnitFormat unitFormat)
        {
            return this.ToString(unitFormat, null, CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return this.ToString(null, formatProvider);
        }

        public string ToString(UnitFormat unitFormat, string format)
        {
            return this.ToString(unitFormat, format, CultureInfo.CurrentCulture);
        }

        public string ToString(UnitFormat unitFormat, IFormatProvider formatProvider)
        {
            return this.ToString(unitFormat, null, formatProvider);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString(UnitFormat.Default, format, formatProvider);
        }

        public string ToString(UnitFormat unitFormat, string format, IFormatProvider formatProvider)
        {
            return QuantityHelper.ToString(
                this.Unit.FormatValue(this.value, format, formatProvider),
                UnitFormatHelper.GetNotation(this.Unit, unitFormat));
        }

        /// <summary>
        /// Creates the quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="Quantity"/>.</returns>
        public Quantity CreateQuantity(double value, IUnit unit)
        {
            return new Quantity(value, unit);
        }
    }
}