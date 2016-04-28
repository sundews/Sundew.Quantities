namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="MagneticFlux"/>.
    /// </summary>
    public class MagneticFluxUnitSelector : PrefixSelector<IMagneticFluxUnitSelector, IPrefixSelector<IMagneticFluxUnitSelector>>, IMagneticFluxUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Webers;

        /// <summary>
        /// Gets the Siemens.
        /// </summary>
        /// <value>
        /// The Siemens.
        /// </value>
        public Expression Webers => this.SpecifyUnit(UnitDefinitions.Weber);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Weber;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IMagneticFluxUnitSelector}"/></returns>
        protected override IPrefixSelector<IMagneticFluxUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IMagneticFluxUnitSelector"/>.</returns>
        protected override IMagneticFluxUnitSelector GetUnits()
        {
            return this;
        }
    }
}