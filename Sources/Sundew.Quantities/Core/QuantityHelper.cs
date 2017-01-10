// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core
{
    using System.Diagnostics.Contracts;
    using Sundew.Quantities.Core.Exceptions;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Internals;
    using Sundew.Quantities.Representations.Units;

    /// <summary>
    /// Helper class for code sharing when implementing quantities.
    /// </summary>
    public static class QuantityHelper
    {
        private static readonly IUnit IdentityUnit = new Unit(string.Empty);

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public static int GetHashCode(IQuantity quantity)
        {
            return QuantityOperations.ConvertToUnit(quantity, IdentityUnit).GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="notation">The notation.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public static string ToString(string value, string notation)
        {
            return string.Format(Constants.ValueAndUnitFormat, value, notation);
        }

        /// <summary>
        /// Checks if the lhs and the rhs are equal.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// A value indication whether the lhs and the rhs are equal.
        /// </returns>
        public static bool AreEqual(IQuantity lhs, object rhs)
        {
            return AreEqual(lhs, rhs as IQuantity);
        }

        /// <summary>
        /// Checks if the lhs and the rhs are equal.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// A value indication whether the lhs and the rhs are equal.
        /// </returns>
        public static bool AreEqual(IQuantity lhs, IQuantity rhs)
        {
            if (lhs == null || rhs == null)
            {
                return false;
            }

            var lhsUnit = lhs.Unit;
            var rhsUnit = rhs.Unit;

            if (!UnitEqualityHelper.AreBaseUnitsEqual(lhsUnit, rhsUnit))
            {
                return false;
            }

            var rhsValue = QuantityOperations.ConvertToUnit(rhs, lhsUnit);
            return lhs.Value.Equals(rhsValue);
        }

        /// <summary>
        /// Compares the lhs to the rhs.
        /// </summary>
        /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The result of <see cref="double"/> Compare based the rhs converted to the same unit as lhs.
        /// </returns>
        public static int CompareTo<TQuantity>(IQuantity lhs, object rhs)
            where TQuantity : IQuantity
        {
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            return CompareTo(lhs, (TQuantity)rhs);
        }

        /// <summary>
        /// Compares the lhs to the rhs.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The result of <see cref="int"/> Compare based the rhs converted to the same unit as lhs.</returns>
        public static int CompareTo(IQuantity lhs, IQuantity rhs)
        {
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);

            var lhsUnit = lhs.Unit;
            var rhsUnit = rhs.Unit;

            if (!UnitEqualityHelper.AreBaseUnitsEqual(lhsUnit, rhsUnit))
            {
                throw new UnitMismatchException(OperationType.Compare, lhsUnit, rhsUnit);
            }

            var rhsValue = QuantityOperations.ConvertToUnit(rhs, lhs.Unit);
            return lhs.Value.CompareTo(rhsValue);
        }
    }
}