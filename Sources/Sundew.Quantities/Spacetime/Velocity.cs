// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Velocity.cs" company="Hukano">
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
    /// Represents a velocity quantity.
    /// </summary>
    public sealed partial class Velocity : Quantity<Velocity, VelocityUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity" /> class.
        /// </summary>
        /// <param name="velocity">The velocity.</param>
        /// <param name="velocityUnitSelector">The velocity unit selector.</param>
        public Velocity(double velocity, SelectUnit<VelocityUnitSelector> velocityUnitSelector)
            : base(velocity, velocityUnitSelector(new VelocityUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Velocity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity"/> class.
        /// </summary>
        /// <param name="velocity">The velocity.</param>
        /// <param name="velocityUnit">The velocity unit.</param>
        public Velocity(double velocity, IUnit velocityUnit)
            : base(velocity, velocityUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity" /> class.
        /// </summary>
        /// <param name="velocity">The velocity.</param>
        public Velocity(double velocity)
            : this(velocity, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Velocity"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Velocity Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Velocity operator ++(Velocity lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Velocity operator --(Velocity lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a velocity quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="Velocity"/>.</returns>
        public override Velocity CreateQuantity(double value, IUnit unit)
        {
            return new Velocity(value, unit);
        }

        /// <summary>
        /// Creates the unit selector.
        /// </summary>
        /// <returns>A <see cref="VelocityUnitSelector"/>.</returns>
        public override VelocityUnitSelector CreateUnitSelector()
        {
            return new VelocityUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Velocity> Interval(double min, double max, SelectUnit<VelocityUnitSelector> unitSelector)
        {
            return new Interval<Velocity>(min, max, unitSelector(new VelocityUnitSelector()));
        }
    }
}