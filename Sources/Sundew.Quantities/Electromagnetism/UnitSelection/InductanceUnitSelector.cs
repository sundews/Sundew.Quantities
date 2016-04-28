namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Inductance"/>.
    /// </summary>
    public class InductanceUnitSelector : PrefixSelector<IInductanceUnitSelector, IPrefixSelector<IInductanceUnitSelector>>, IInductanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Henry;

        /// <summary>
        /// Gets the siemens.
        /// </summary>
        /// <value>
        /// The siemens.
        /// </value>
        public Expression Henry => this.SpecifyUnit(UnitDefinitions.Henry);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Henry;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IInductanceUnitSelector}"/></returns>
        protected override IPrefixSelector<IInductanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IInductanceUnitSelector"/>.</returns>
        protected override IInductanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}