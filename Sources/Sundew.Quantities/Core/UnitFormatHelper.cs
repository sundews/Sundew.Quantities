// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitFormatHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Internals;

    /// <summary>
    /// Helper methods for formatting units.
    /// </summary>
    public static class UnitFormatHelper
    {
        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="notation">The notation.</param>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        public static string ToString(Prefix prefix, string notation)
        {
            return string.Format(Constants.PrefixAndUnitFormat, prefix.Notation, notation);
        }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <param name="unitFormat">The unit format.</param>
        /// <returns>The notation.</returns>
        public static string GetNotation(IUnit unit, UnitFormat unitFormat)
        {
            var notation = unit.Notation;
            if (unitFormat.HasFlag(UnitFormat.SurroundInBrackets))
            {
                return $"[{notation}]";
            }

            return notation;
        }
    }
}