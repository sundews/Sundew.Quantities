// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Acceleration.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spacetime
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spacetime.UnitSelection;

    /// <summary>
    /// Represents a quantity of acceleration.
    /// </summary>
    public sealed partial class Acceleration : Quantity<Acceleration, AccelerationUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration" /> class.
        /// </summary>
        /// <param name="acceleration">The acceleration.</param>
        /// <param name="accelerationUnitSelector">The length unit selector.</param>
        public Acceleration(double acceleration, SelectUnit<AccelerationUnitSelector> accelerationUnitSelector)
            : base(acceleration, accelerationUnitSelector(new AccelerationUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Acceleration(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        /// <param name="acceleration">The acceleration.</param>
        /// <param name="accelerationUnit">The acceleration unit.</param>
        public Acceleration(double acceleration, IUnit accelerationUnit)
            : base(acceleration, accelerationUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration" /> class.
        /// </summary>
        /// <param name="acceleration">The acceleration.</param>
        public Acceleration(double acceleration)
            : this(acceleration, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Acceleration"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Acceleration Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Acceleration operator ++(Acceleration lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Acceleration operator --(Acceleration lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the acceleration quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>An <see cref="Acceleration"/>.</returns>
        public override Acceleration CreateQuantity(double value, IUnit unit)
        {
            return new Acceleration(value, unit);
        }

        /// <summary>
        /// Creates the acceleration unit selector.
        /// </summary>
        /// <returns>An <see cref="AccelerationUnitSelector"/>.</returns>
        public override AccelerationUnitSelector CreateUnitSelector()
        {
            return new AccelerationUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Acceleration> Interval(
            double min,
            double max,
            SelectUnit<AccelerationUnitSelector> unitSelector)
        {
            return new Interval<Acceleration>(min, max, unitSelector(new AccelerationUnitSelector()));
        }
    }
}