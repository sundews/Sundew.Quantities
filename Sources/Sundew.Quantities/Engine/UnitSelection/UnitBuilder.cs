// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitBuilder.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Enables building derived units by implementing multiplication and division operators.
    /// </summary>
    internal static class UnitBuilder
    {
        /// <summary>
        /// Builds the unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>A new <see cref="IUnit"/>.</returns>
        internal static IUnit BuildUnit(IUnit unit)
        {
            return BuildUnit(unit.GetExpression());
        }

        /// <summary>
        /// Builds the unit.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="IUnit"/>.</returns>
        internal static IUnit BuildUnit(Expression expression)
        {
            return UnitSystem.UnitFactory.Create(expression);
        }
    }
}