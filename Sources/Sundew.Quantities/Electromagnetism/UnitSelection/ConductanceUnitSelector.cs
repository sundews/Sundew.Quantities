namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Conductance"/>.
    /// </summary>
    public class ConductanceUnitSelector : PrefixSelector<IConductanceUnitSelector, IPrefixSelector<IConductanceUnitSelector>>, IConductanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Siemens;

        /// <summary>
        /// Gets the Siemens.
        /// </summary>
        /// <value>
        /// The Siemens.
        /// </value>
        public Expression Siemens => this.SpecifyUnit(UnitDefinitions.Siemens);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Siemens;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IConductanceUnitSelector}"/></returns>
        protected override IPrefixSelector<IConductanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IConductanceUnitSelector"/>.</returns>
        protected override IConductanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}