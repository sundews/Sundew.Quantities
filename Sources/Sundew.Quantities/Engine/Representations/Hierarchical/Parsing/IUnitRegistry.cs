// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IUnitRegistry.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing a unit registry.
    /// </summary>
    public interface IUnitRegistry : ILexemeRegistry<IUnit>, ILexemeRegistry<Prefix>
    {
        /// <summary>
        /// Gets the unit notations.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{String}"/>.</returns>
        IEnumerable<string> GetUnitNotations();

        /// <summary>
        /// Gets the prefix notations.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{String}"/>.</returns>
        IEnumerable<string> GetPrefixNotations();

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{IUnit}" />.
        /// </returns>
        IEnumerable<IUnit> GetUnits();

        /// <summary>
        /// Gets the prefixes.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{Prefix}" />.
        /// </returns>
        IEnumerable<Prefix> GetPrefixes();
    }
}