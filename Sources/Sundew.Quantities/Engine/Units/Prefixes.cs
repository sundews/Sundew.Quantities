// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prefixes.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Units
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Contains the standard prefixes.
    /// </summary>
    public static class Prefixes
    {
        /// <summary>The yotta prefix.</summary>
        public static readonly Prefix Yotta = new FactoredPrefix("Yotta", Math.Pow(10, 24), "Y");

        /// <summary>The zetta prefix.</summary>
        public static readonly Prefix Zetta = new FactoredPrefix("Zetta", Math.Pow(10, 21), "Z");

        /// <summary>The exa prefix.</summary>
        public static readonly Prefix Exa = new FactoredPrefix("Exa", Math.Pow(10, 18), "E");

        /// <summary>The peta prefix.</summary>
        public static readonly Prefix Peta = new FactoredPrefix("Peta", Math.Pow(10, 15), "P");

        /// <summary>The tera prefix.</summary>
        public static readonly Prefix Tera = new FactoredPrefix("Tera", Math.Pow(10, 12), "T");

        /// <summary>The giga prefix.</summary>
        public static readonly Prefix Giga = new FactoredPrefix("Giga", Math.Pow(10, 9), "G");

        /// <summary>The mega prefix.</summary>
        public static readonly Prefix Mega = new FactoredPrefix("Mega", Math.Pow(10, 6), "M");

        /// <summary>The kilo prefix.</summary>
        public static readonly Prefix Kilo = new FactoredPrefix("Kilo", Math.Pow(10, 3), "k");

        /// <summary>The hecto prefix.</summary>
        public static readonly Prefix Hecto = new FactoredPrefix("Hecto", Math.Pow(10, 2), "h");

        /// <summary>The deca prefix.</summary>
        public static readonly Prefix Deca = new FactoredPrefix("Deca", 10, "da");

        /// <summary>The deci prefix.</summary>
        public static readonly Prefix Deci = new FactoredPrefix("Deci", 0.1, "d");

        /// <summary>The centi prefix.</summary>
        public static readonly Prefix Centi = new FactoredPrefix("Centi", Math.Pow(10, -2), "c");

        /// <summary>The milli prefix.</summary>
        public static readonly Prefix Milli = new FactoredPrefix("Milli", Math.Pow(10, -3), "m");

        /// <summary>The micro prefix.</summary>
        public static readonly Prefix Micro = new FactoredPrefix("Micro", Math.Pow(10, -6), "μ");

        /// <summary>The nano prefix.</summary>
        public static readonly Prefix Nano = new FactoredPrefix("Nano", Math.Pow(10, -9), "n");

        /// <summary>The pico prefix.</summary>
        public static readonly Prefix Pico = new FactoredPrefix("Pico", Math.Pow(10, -12), "p");

        /// <summary>The femto prefix.</summary>
        public static readonly Prefix Femto = new FactoredPrefix("Femto", Math.Pow(10, -15), "f");

        /// <summary>The atto prefix.</summary>
        public static readonly Prefix Atto = new FactoredPrefix("Atto", Math.Pow(10, -18), "a");

        /// <summary>The zepto prefix.</summary>
        public static readonly Prefix Zepto = new FactoredPrefix("Zepto", Math.Pow(10, -21), "z");

        /// <summary>The yocto prefix.</summary>
        public static readonly Prefix Yocto = new FactoredPrefix("Yocto", Math.Pow(10, -24), "y");
    }
}