namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Periodics.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Charge"/>.
    /// </summary>
    public class ChargeUnitSelector : PrefixSelector<IChargeUnitSelector, IPrefixSelector<IChargeUnitSelector>>, IChargeUnitSelector
    {
        private readonly TimeUnits timeUnits = new TimeUnits();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Coulombs;

        /// <summary>
        /// Gets the coulomb.
        /// </summary>
        /// <value>
        /// The coulomb.
        /// </value>
        public Expression Coulombs => this.SpecifyUnit(UnitDefinitions.Coulomb);

        /// <summary>
        /// Gets the ampere.
        /// </summary>
        /// <value>
        /// The ampere.
        /// </value>
        public Expression Amperes => this.SpecifyUnit(UnitDefinitions.Ampere);

        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second.
        /// </value>
        public Expression Seconds => this.SpecifyUnit(this.timeUnits.Seconds);

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public Expression Years => this.SpecifyUnit(this.timeUnits.Years);

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        public Expression Months => this.SpecifyUnit(this.timeUnits.Months);

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week.
        /// </value>
        public Expression Weeks => this.SpecifyUnit(this.timeUnits.Weeks);

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public Expression Days => this.SpecifyUnit(this.timeUnits.Days);

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute.
        /// </value>
        public Expression Minutes => this.SpecifyUnit(this.timeUnits.Minutes);

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour.
        /// </value>
        public Expression Hours => this.SpecifyUnit(this.timeUnits.Hours);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Coulomb;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixSelector<IChargeUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IChargeUnitSelector GetUnits()
        {
            return this;
        }
    }
}