// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitHelper.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Units
{
    using System.Diagnostics.Contracts;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Internals;

    /// <summary>
    /// Helper class for <see cref="IUnit" />.
    /// </summary>
    public static class UnitHelper
    {
        /// <summary>
        /// Checks if the LHS and the RHS base units are equal.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
        /// <param name="rhs">The RHS <see cref="IUnit"/>.</param>
        /// <returns>
        ///     <c>true</c>, if the base unit are the equal.
        /// </returns>
        public static bool AreBaseUnitsEqual(IUnit lhs, IUnit rhs)
        {
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            return lhs.BaseUnit.Equals(rhs.BaseUnit);
        }

        /// <summary>
        /// Checks if the LHS and the RHS are equal.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
        /// <param name="rhs">The RHS <see cref="object"/>.</param>
        /// <returns>
        /// A value indication whether the lhs and the rhs are equal.
        /// </returns>
        public static bool AreUnitsEqual(IUnit lhs, object rhs)
        {
            return AreUnitsEqual(lhs, rhs as IUnit);
        }

        /// <summary>
        /// Checks if the lhs and the rhs are equal.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
        /// <param name="rhs">The RHS <see cref="IUnit"/>.</param>
        /// <returns>
        /// A value indication whether the lhs and the rhs are equal.
        /// </returns>
        public static bool AreUnitsEqual(IUnit lhs, IUnit rhs)
        {
            if (rhs == null || lhs == null)
            {
                return false;
            }

            if (!lhs.PrefixFactor.Equals(rhs.PrefixFactor))
            {
                return false;
            }

            if (!IsNotationEqual(lhs, rhs))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public static int GetHashCode(IUnit unit)
        {
            Contract.Requires(unit != null);
            return unit.PrefixFactor.GetHashCode() ^ unit.Notation.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="notation">The notation.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public static string ToString(Prefix prefix, string notation)
        {
            Contract.Requires(prefix != null);
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
            Contract.Requires(unit != null);
            var notation = unit.Notation;
            if (unitFormat.HasFlag(UnitFormat.SurroundInBrackets))
            {
                return $"[{notation}]";
            }

            return notation;
        }

        internal static bool IsNotationEqual(IUnit lhs, IUnit rhs)
        {
            return lhs.GetNotationWithoutPrefix().Equals(rhs.GetNotationWithoutPrefix());
        }
    }
}