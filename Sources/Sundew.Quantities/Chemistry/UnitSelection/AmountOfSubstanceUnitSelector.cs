namespace Sundew.Quantities.Chemistry.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="AmountOfSubstance"/>.
    /// </summary>
    public class AmountOfSubstanceUnitSelector : PrefixSelector<IAmountOfSubstanceUnitSelector, IPrefixSelector<IAmountOfSubstanceUnitSelector>>, IAmountOfSubstanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Mole;

        /// <summary>
        /// Gets the Mole.
        /// </summary>
        /// <value>
        /// The Mole.
        /// </value>
        public Expression Mole => this.SpecifyUnit(UnitDefinitions.Mole);

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IAmountOfSubstanceUnitSelector}"/></returns>
        protected override IPrefixSelector<IAmountOfSubstanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IAmountOfSubstanceUnitSelector"/>.</returns>
        protected override IAmountOfSubstanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}