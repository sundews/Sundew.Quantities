namespace Sundew.Quantities
{
    using System;
    using System.Diagnostics.Contracts;

    using Sundew.Base.Numeric;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Represents a range of a given quantity.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    public sealed class Interval<TQuantity>
        where TQuantity : IQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interval{TQuantity}"/> class.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unit">The unit.</param>
        public Interval(double min, double max, IUnit unit)
        {
            Contract.Requires(unit != null);
            Contract.Requires<ArgumentException>(min <= max, "min must be less than max");
            this.Min = min;
            this.Max = max;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interval{TQuantity}"/> class.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="expression">The expression.</param>
        internal Interval(double min, double max, Expression expression)
            : this(min, max, UnitBuilder.BuildUnit(expression))
        {
        }

        /// <summary>
        /// Gets the minimum.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public double Min { get; }

        /// <summary>
        /// Gets the maximum.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public double Max { get; }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <value>
        /// The unit.
        /// </value>
        public IUnit Unit { get; }

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public double Length => this.Max - this.Min;

        /// <summary>
        /// Gets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        public double Center => (this.Min + this.Max) / 2;

        /// <summary>
        /// Gets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        public double Radius => this.Length / 2;

        /// <summary>
        /// Determines whether this interval contains the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="intervalMode">The interval mode.</param>
        /// <returns>
        ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
        /// </returns>
        public bool Contains(TQuantity quantity, IntervalMode intervalMode = IntervalMode.Inclusive)
        {
            Contract.Requires(quantity != null);
            return quantity.ToDouble(this.Unit).IsWithinInterval(this.Min, this.Max, intervalMode);
        }

        /// <summary>
        /// Determines whether this interval contains the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
        /// </returns>
        public bool ContainsInclusive(TQuantity quantity)
        {
            Contract.Requires(quantity != null);
            return this.Contains(quantity);
        }

        /// <summary>
        /// Determines whether this interval contains the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        ///   <c>true</c> if the specified quantity is within the interval, otherwise <c>false</c>.
        /// </returns>
        public bool ContainsExclusive(TQuantity quantity)
        {
            Contract.Requires(quantity != null);
            return this.Contains(quantity, IntervalMode.Exclusive);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Interval: {this.Min}, {this.Max} [{this.Unit}]";
        }
    }
}