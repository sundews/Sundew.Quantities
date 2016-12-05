// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using System.Collections.Generic;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Sundew.Quantities.Units;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// </summary>
    public class MassUnitSelector : PrefixSelector<IMassUnitSelector, IPrefixSelector<IMassUnitSelector>>,
                                    IMassUnitSelector
    {
        private readonly MassUnits massUnits = new MassUnits();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.KiloGrams;

        /// <summary>
        /// Gets the Gram.
        /// </summary>
        /// <value>
        /// The Gram.
        /// </value>
        public Expression Grams => this.SpecifyUnit(this.massUnits.Grams);

        /// <summary>
        /// Gets the kilo gram.
        /// </summary>
        /// <value>
        /// The kilo gram.
        /// </value>
        public Expression KiloGrams => this.SpecifyUnit(this.massUnits.KiloGrams);

        /// <summary>
        /// Gets the tonne.
        /// </summary>
        /// <value>
        /// The tonne.
        /// </value>
        public Expression Tonnes => this.SpecifyUnit(this.massUnits.Tonnes);

        /// <summary>
        /// Gets the chinese metric ounce.
        /// </summary>
        /// <value>
        /// The chinese metric ounce.
        /// </value>
        public Expression ChineseMetricOunces => this.SpecifyUnit(this.massUnits.ChineseMetricOunces);

        /// <summary>
        /// Gets the dutch metric ounce.
        /// </summary>
        /// <value>
        /// The dutch metric ounce.
        /// </value>
        public Expression DutchMetricOunces => this.SpecifyUnit(this.massUnits.DutchMetricOunces);

        /// <summary>
        /// Gets the international avoirdupois ounce.
        /// </summary>
        /// <value>
        /// The international avoirdupois ounce.
        /// </value>
        public Expression InternationalAvoirdupoisOunces
            => this.SpecifyUnit(this.massUnits.InternationalAvoirdupoisOunces);

        /// <summary>
        /// Gets the international troy ounce.
        /// </summary>
        /// <value>
        /// The international troy ounce.
        /// </value>
        public Expression InternationalTroyOunces => this.SpecifyUnit(this.massUnits.InternationalTroyOunces);

        /// <summary>
        /// Gets the maria theresa ounce.
        /// </summary>
        /// <value>
        /// The maria theresa ounce.
        /// </value>
        public Expression MariaTheresaOunces => this.SpecifyUnit(this.massUnits.MariaTheresaOunces);

        /// <summary>
        /// Gets the ounce.
        /// </summary>
        /// <value>
        /// The ounce.
        /// </value>
        public Expression Ounces => this.SpecifyUnit(this.massUnits.Ounces);

        /// <summary>
        /// Gets the spanish ounce.
        /// </summary>
        /// <value>
        /// The spanish ounce.
        /// </value>
        public Expression SpanishOunces => this.SpecifyUnit(this.massUnits.SpanishOunces);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.KiloGram;
            yield return UnitDefinitions.Gram;
            yield return UnitDefinitions.Tonne;
            yield return UnitDefinitions.ChineseMetricOunce;
            yield return UnitDefinitions.DutchMetricOunce;
            yield return UnitDefinitions.InternationalAvoirdupoisOunce;
            yield return UnitDefinitions.InternationalTroyOunce;
            yield return UnitDefinitions.MariaTheresaOunce;
            yield return UnitDefinitions.Ounce;
            yield return UnitDefinitions.SpanishOunce;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixSelector<IMassUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IMassUnitSelector GetUnits()
        {
            return this;
        }
    }
}