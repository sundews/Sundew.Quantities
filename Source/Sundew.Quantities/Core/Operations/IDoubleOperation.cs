// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDoubleOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Core.Operations
{
    /// <summary>
    /// Interface for implementing <see cref="double"/> operations.
    /// </summary>
    public interface IDoubleOperation
    {
        /// <summary>
        /// Executes the operation for the specified values.
        /// </summary>
        /// <param name="lhs">The LHS value.</param>
        /// <param name="rhs">The RHS value.</param>
        /// <returns>A new <see cref="double"/>.</returns>
        double Execute(double lhs, double rhs);
    }
}