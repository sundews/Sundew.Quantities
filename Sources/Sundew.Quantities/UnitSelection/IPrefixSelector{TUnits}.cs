// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrefixSelector{TUnits}.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    /// <summary>
    /// Interface for implementing a prefix selector.
    /// </summary>
    /// <typeparam name="TUnits">The type of the unit selector.</typeparam>
    public interface IPrefixSelector<out TUnits>
    {
        /// <summary>
        /// Gets the yotta.
        /// </summary>
        /// <value>
        /// The yotta prefix.
        /// </value>
        TUnits Yotta { get; }

        /// <summary>
        /// Gets the zetta.
        /// </summary>
        /// <value>
        /// The zetta prefix.
        /// </value>
        TUnits Zetta { get; }

        /// <summary>
        /// Gets the exa.
        /// </summary>
        /// <value>
        /// The exa prefix.
        /// </value>
        TUnits Exa { get; }

        /// <summary>
        /// Gets the peta.
        /// </summary>
        /// <value>
        /// The peta prefix.
        /// </value>
        TUnits Peta { get; }

        /// <summary>
        /// Gets the tera.
        /// </summary>
        /// <value>
        /// The tera prefix.
        /// </value>
        TUnits Tera { get; }

        /// <summary>
        /// Gets the giga.
        /// </summary>
        /// <value>
        /// The giga prefix.
        /// </value>
        TUnits Giga { get; }

        /// <summary>
        /// Gets the mega.
        /// </summary>
        /// <value>
        /// The mega prefix.
        /// </value>
        TUnits Mega { get; }

        /// <summary>
        /// Gets the kilo.
        /// </summary>
        /// <value>
        /// The kilo prefix.
        /// </value>
        TUnits Kilo { get; }

        /// <summary>
        /// Gets the hecto.
        /// </summary>
        /// <value>
        /// The hecto prefix.
        /// </value>
        TUnits Hecto { get; }

        /// <summary>
        /// Gets the deca.
        /// </summary>
        /// <value>
        /// The deca prefix.
        /// </value>
        TUnits Deca { get; }

        /// <summary>
        /// Gets the deci.
        /// </summary>
        /// <value>
        /// The deci prefix.
        /// </value>
        TUnits Deci { get; }

        /// <summary>
        /// Gets the centi.
        /// </summary>
        /// <value>
        /// The centi prefix.
        /// </value>
        TUnits Centi { get; }

        /// <summary>
        /// Gets the milli.
        /// </summary>
        /// <value>
        /// The milli prefix.
        /// </value>
        TUnits Milli { get; }

        /// <summary>
        /// Gets the micro.
        /// </summary>
        /// <value>
        /// The micro prefix.
        /// </value>
        TUnits Micro { get; }

        /// <summary>
        /// Gets the nano.
        /// </summary>
        /// <value>
        /// The nano prefix.
        /// </value>
        TUnits Nano { get; }

        /// <summary>
        /// Gets the pico.
        /// </summary>
        /// <value>
        /// The pico prefix.
        /// </value>
        TUnits Pico { get; }

        /// <summary>
        /// Gets the femto.
        /// </summary>
        /// <value>
        /// The femto prefix.
        /// </value>
        TUnits Femto { get; }

        /// <summary>
        /// Gets the atto.
        /// </summary>
        /// <value>
        /// The atto prefix.
        /// </value>
        TUnits Atto { get; }

        /// <summary>
        /// Gets the zepto.
        /// </summary>
        /// <value>
        /// The zepto prefix.
        /// </value>
        TUnits Zepto { get; }

        /// <summary>
        /// Gets the yocto.
        /// </summary>
        /// <value>
        /// The yocto prefix.
        /// </value>
        TUnits Yocto { get; }

        /// <summary>
        /// Specifies a custom prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <returns>The available <see cref="TUnits"/>.</returns>
        TUnits By(double prefix);
    }
}