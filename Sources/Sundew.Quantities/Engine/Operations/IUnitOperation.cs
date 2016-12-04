// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing <see cref="IUnit"/> operations.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IUnitOperation<out TResult>
    {
        /// <summary>
        /// Executes the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS unit.</param>
        /// <param name="rhs">The RHS unit.</param>
        /// <param name="reduceByBaseUnits">If set to <c>true</c> reduction will be done with base units.</param>
        /// <returns>A new <see cref="TResult"/>.</returns>
        TResult Execute(IUnit lhs, IUnit rhs, bool reduceByBaseUnits);
    }
}