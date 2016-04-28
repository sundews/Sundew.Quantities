namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Pressure"/>.
    /// </summary>
    public class PressureUnitSelector : PrefixSelector<IPressureUnitSelector, IPrefixSelector<IPressureUnitSelector>>, IPressureUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Pascals;

        /// <summary>
        /// Gets the Pascal.
        /// </summary>
        /// <value>
        /// The Pascal.
        /// </value>
        public Expression Pascals => this.SpecifyUnit(UnitDefinitions.Pascal);

        /// <summary>
        /// Gets the bar.
        /// </summary>
        /// <value>
        /// The bar.
        /// </value>
        public Expression Bars => this.SpecifyUnit(UnitDefinitions.Bar);

        /// <summary>
        /// Gets or sets the technical atmosphere.
        /// </summary>
        /// <value>
        /// The technical atmosphere.
        /// </value>
        public Expression TechnicalAtmospheres => this.SpecifyUnit(UnitDefinitions.TechnicalAtmosphere);

        /// <summary>
        /// Gets or sets the standard atmosphere.
        /// </summary>
        /// <value>
        /// The standard atmosphere.
        /// </value>
        public Expression StandardAtmospheres => this.SpecifyUnit(UnitDefinitions.StandardAtmosphere);

        /// <summary>
        /// Gets or sets the torr.
        /// </summary>
        /// <value>
        /// The torr.
        /// </value>
        public Expression Torrs => this.SpecifyUnit(UnitDefinitions.Torr);

        /// <summary>
        /// Gets or sets the psi.
        /// </summary>
        /// <value>
        /// The psi.
        /// </value>
        public Expression Psi => this.SpecifyUnit(UnitDefinitions.Psi);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Pascal;
            yield return UnitDefinitions.Bar;
            yield return UnitDefinitions.TechnicalAtmosphere;
            yield return UnitDefinitions.StandardAtmosphere;
            yield return UnitDefinitions.Torr;
            yield return UnitDefinitions.Psi;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixSelector<IPressureUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPressureUnitSelector GetUnits()
        {
            return this;
        }
    }
}