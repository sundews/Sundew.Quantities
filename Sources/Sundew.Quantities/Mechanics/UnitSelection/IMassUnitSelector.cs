// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IMassUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Mass"/> unit selector.
    /// </summary>
    public interface IMassUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the gram.
        /// </summary>
        /// <value>
        /// The gram <see cref="Expression"/>.
        /// </value>
        Expression Grams { get; }

        /// <summary>
        /// Gets the kilo gram.
        /// </summary>
        /// <value>
        /// The kilo gram <see cref="Expression"/>.
        /// </value>
        Expression KiloGrams { get; }

        /// <summary>
        /// Gets the tonne.
        /// </summary>
        /// <value>
        /// The tonne <see cref="Expression"/>.
        /// </value>
        Expression Tonnes { get; }

        /// <summary>
        /// Gets the chinese metric ounce.
        /// </summary>
        /// <value>
        /// The chinese metric ounce <see cref="Expression"/>.
        /// </value>
        Expression ChineseMetricOunces { get; }

        /// <summary>
        /// Gets the dutch metric ounce.
        /// </summary>
        /// <value>
        /// The dutch metric ounce <see cref="Expression"/>.
        /// </value>
        Expression DutchMetricOunces { get; }

        /// <summary>
        /// Gets the international avoirdupois ounce.
        /// </summary>
        /// <value>
        /// The international avoirdupois ounce <see cref="Expression"/>.
        /// </value>
        Expression InternationalAvoirdupoisOunces { get; }

        /// <summary>
        /// Gets the international troy ounce.
        /// </summary>
        /// <value>
        /// The international troy ounce.
        /// </value>
        Expression InternationalTroyOunces { get; }

        /// <summary>
        /// Gets the maria theresa ounce.
        /// </summary>
        /// <value>
        /// The maria theresa ounce <see cref="Expression"/>.
        /// </value>
        Expression MariaTheresaOunces { get; }

        /// <summary>
        /// Gets the ounce.
        /// </summary>
        /// <value>
        /// The ounce <see cref="Expression"/>.
        /// </value>
        Expression Ounces { get; }

        /// <summary>
        /// Gets the spanish ounce.
        /// </summary>
        /// <value>
        /// The spanish ounce <see cref="Expression"/>.
        /// </value>
        Expression SpanishOunces { get; }
    }
}