// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Units
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Extends <see cref="IUnit"/> with easy to use methods.
    /// </summary>
    public static class UnitExtensions
    {
        /// <summary>
        /// Raises the specified LHS into the power of the RHS.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="IUnit"/>.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>A new <see cref="Expression"/>.</returns>
        public static Expression Exp(this IUnit lhs, double exponent)
        {
            return new MagnitudeExpression(lhs.GetExpression(), new ConstantExpression(exponent));
        }
    }
}