// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnergyUnitSelector.generated.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace Sundew.Quantities.UnitSelectors
{
    using global::Sundew.Quantities.Representations.Expressions;
    using global::Sundew.Quantities.Representations.Units;
    using global::Sundew.Quantities.UnitSelection;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Generic;

    /// <summary>
    /// UnitSelector for <see cref="Energy"/>.
    /// </summary>
    [GeneratedCode("Sundew.Quantities.Generator.UnitSelectors.UnitSelectorGenerator", "1.0.0.0")]
    public class EnergyUnitSelector : IExponentSelector<IPrefixedEnergyUnitSelector>, IPrefixedEnergyUnitSelector
    {
        private int actualExponent = 1;

        private Prefix actualPrefix;

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => UnitDefinitions.Joule;

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{IUnit}" />.
        /// </returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Joule;
        }

        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <value>
        /// The square.
        /// </value>
        public IPrefixedEnergyUnitSelector Square => this.GetPrefixesAndUnits(2);

        /// <summary>
        /// Gets the cubic.
        /// </summary>
        /// <value>
        /// The cubic.
        /// </value>
        public IPrefixedEnergyUnitSelector Cubic => this.GetPrefixesAndUnits(3);

        /// <summary>
        /// Gets the quartic.
        /// </summary>
        /// <value>
        /// The quartic.
        /// </value>
        public IPrefixedEnergyUnitSelector Quartic => this.GetPrefixesAndUnits(4);

        /// <summary>
        /// Gets the quintic.
        /// </summary>
        /// <value>
        /// The quintic.
        /// </value>
        public IPrefixedEnergyUnitSelector Quintic => this.GetPrefixesAndUnits(5);

        /// <summary>
        /// Gets the yotta.
        /// </summary>
        /// <value>
        /// The yotta.
        /// </value>
        public IEnergyUnitSelector Yotta => this.GetUnits(Prefixes.Yotta);

        /// <summary>
        /// Gets the zetta.
        /// </summary>
        /// <value>
        /// The zetta.
        /// </value>
        public IEnergyUnitSelector Zetta => this.GetUnits(Prefixes.Zetta);

        /// <summary>
        /// Gets the exa.
        /// </summary>
        /// <value>
        /// The exa.
        /// </value>
        public IEnergyUnitSelector Exa => this.GetUnits(Prefixes.Exa);

        /// <summary>
        /// Gets the peta.
        /// </summary>
        /// <value>
        /// The peta.
        /// </value>
        public IEnergyUnitSelector Peta => this.GetUnits(Prefixes.Peta);

        /// <summary>
        /// Gets the tera.
        /// </summary>
        /// <value>
        /// The tera.
        /// </value>
        public IEnergyUnitSelector Tera => this.GetUnits(Prefixes.Tera);

        /// <summary>
        /// Gets the giga.
        /// </summary>
        /// <value>
        /// The giga.
        /// </value>
        public IEnergyUnitSelector Giga => this.GetUnits(Prefixes.Giga);

        /// <summary>
        /// Gets the mega.
        /// </summary>
        /// <value>
        /// The mega.
        /// </value>
        public IEnergyUnitSelector Mega => this.GetUnits(Prefixes.Mega);

        /// <summary>
        /// Gets the kilo.
        /// </summary>
        /// <value>
        /// The kilo.
        /// </value>
        public IEnergyUnitSelector Kilo => this.GetUnits(Prefixes.Kilo);

        /// <summary>
        /// Gets the hecto.
        /// </summary>
        /// <value>
        /// The hecto.
        /// </value>
        public IEnergyUnitSelector Hecto => this.GetUnits(Prefixes.Hecto);

        /// <summary>
        /// Gets the deca.
        /// </summary>
        /// <value>
        /// The deca.
        /// </value>
        public IEnergyUnitSelector Deca => this.GetUnits(Prefixes.Deca);

        /// <summary>
        /// Gets the deci.
        /// </summary>
        /// <value>
        /// The deci.
        /// </value>
        public IEnergyUnitSelector Deci => this.GetUnits(Prefixes.Deci);

        /// <summary>
        /// Gets the centi.
        /// </summary>
        /// <value>
        /// The centi.
        /// </value>
        public IEnergyUnitSelector Centi => this.GetUnits(Prefixes.Centi);

        /// <summary>
        /// Gets the milli.
        /// </summary>
        /// <value>
        /// The milli.
        /// </value>
        public IEnergyUnitSelector Milli => this.GetUnits(Prefixes.Milli);

        /// <summary>
        /// Gets the micro.
        /// </summary>
        /// <value>
        /// The micro.
        /// </value>
        public IEnergyUnitSelector Micro => this.GetUnits(Prefixes.Micro);

        /// <summary>
        /// Gets the nano.
        /// </summary>
        /// <value>
        /// The nano.
        /// </value>
        public IEnergyUnitSelector Nano => this.GetUnits(Prefixes.Nano);

        /// <summary>
        /// Gets the pico.
        /// </summary>
        /// <value>
        /// The pico.
        /// </value>
        public IEnergyUnitSelector Pico => this.GetUnits(Prefixes.Pico);

        /// <summary>
        /// Gets the femto.
        /// </summary>
        /// <value>
        /// The femto.
        /// </value>
        public IEnergyUnitSelector Femto => this.GetUnits(Prefixes.Femto);

        /// <summary>
        /// Gets the atto.
        /// </summary>
        /// <value>
        /// The atto.
        /// </value>
        public IEnergyUnitSelector Atto => this.GetUnits(Prefixes.Atto);

        /// <summary>
        /// Gets the zepto.
        /// </summary>
        /// <value>
        /// The zepto.
        /// </value>
        public IEnergyUnitSelector Zepto => this.GetUnits(Prefixes.Zepto);

        /// <summary>
        /// Gets the yocto.
        /// </summary>
        /// <value>
        /// The yocto.
        /// </value>
        public IEnergyUnitSelector Yocto => this.GetUnits(Prefixes.Yocto);

        /// <summary>
        /// Gets the joule expression.
        /// </summary>
        /// <value>
        /// The joule.
        /// </value>
        public Expression Joules => this.SpecifyUnit(UnitDefinitions.Joule);

        /// <summary>
        /// Specifies the prefix by the specified factor.
        /// </summary>
        /// <param name="factor">The factor.</param>
        /// <returns>The available units.</returns>
        public IEnergyUnitSelector By(double factor)
        {
            return this.GetUnits(new FactoredPrefix(factor));
        }

        /// <summary>
        /// Specifies the exponent.
        /// </summary>
        /// <param name="exponent">The exponent.</param>
        public void SpecifyExponent(int exponent)
        {
            this.actualExponent = exponent;
        }

        /// <summary>
        /// Specifies the prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        public void SpecifyPrefix(Prefix prefix)
        {
            this.actualPrefix = prefix;
        }

        /// <summary>
        /// Selects the unit based on the specified magnitude, prefix and base unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>
        /// An <see cref="Expression"/>.
        /// </returns>
        public Expression SpecifyUnit(IUnit unit)
        {
            return UnitSelectorHelper.CreateExpression(ref this.actualExponent, ref this.actualPrefix, unit);
        }

        /// <summary>
        /// Gets the prefixes and unit selector.
        /// </summary>
        /// <param name="exponent">The exponent.</param>
        /// <returns>
        /// The available prefixes and units.
        /// </returns>
        private IPrefixedEnergyUnitSelector GetPrefixesAndUnits(int exponent)
        {
            this.SpecifyExponent(exponent);
            return this;
        }

        /// <summary>
        /// Gets the unit selector.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <returns>The available units.</returns>
        private IEnergyUnitSelector GetUnits(Prefix prefix)
        {
            this.SpecifyPrefix(prefix);
            return this;
        }
    }
}