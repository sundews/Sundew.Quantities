// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityOperations.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Quantities
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Helper class containing simple unit math operations.
    /// </summary>
    public class QuantityOperations
    {
        /// <summary>
        /// Adds the specified RHS to the LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The sum of the two in lhs' unit.
        /// </returns>
        public static IQuantity Add(IQuantity lhs, IQuantity rhs)
        {
            return UnitSystem.QuantityOperations.Addition.Execute(lhs, rhs);
        }

        /// <summary>
        /// Subtracts the specified RHS to the LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The difference of the two in lhs' unit.
        /// </returns>
        public static IQuantity Subtract(IQuantity lhs, IQuantity rhs)
        {
            return UnitSystem.QuantityOperations.Subtraction.Execute(lhs, rhs);
        }

        /// <summary>
        /// Multiplies the specified RHS to the LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The product of the two in lhs' unit.
        /// </returns>
        public static IQuantity Multiply(IQuantity lhs, IQuantity rhs)
        {
            return UnitSystem.QuantityOperations.Multiplication.Execute(lhs, rhs);
        }

        /// <summary>
        /// Divides the specified RHS to the LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The fraction of the two in lhs' unit.
        /// </returns>
        public static IQuantity Divide(IQuantity lhs, IQuantity rhs)
        {
            return UnitSystem.QuantityOperations.Division.Execute(lhs, rhs);
        }

        /// <summary>
        /// Powers the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The lhs powered by rhs.
        /// </returns>
        public static IQuantity Exponential(IQuantity lhs, double rhs)
        {
            return UnitSystem.QuantityOperations.Exponentiation.Execute(lhs, rhs);
        }

        /// <summary>
        /// Nth roots the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The nth root of lhs.
        /// </returns>
        public static IQuantity Root(IQuantity lhs, double rhs)
        {
            return UnitSystem.QuantityOperations.NthRoot.Execute(lhs, rhs);
        }

        /// <summary>
        /// Converts the specified value from its unit to the target unit.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="targetUnit">The target unit.</param>
        /// <returns>
        /// The converted value.
        /// </returns>
        public static double ConvertToUnit(IQuantity quantity, IUnit targetUnit)
        {
            return UnitSystem.QuantityOperations.ConvertToUnit.Execute(quantity, targetUnit);
        }
    }
}