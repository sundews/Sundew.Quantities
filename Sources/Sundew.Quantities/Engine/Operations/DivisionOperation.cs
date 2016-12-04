// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DivisionOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Operations
{
    /// <summary>
    /// Operation for dividing two values.
    /// </summary>
    public class DivisionOperation : IDoubleOperation
    {
        /// <summary>
        /// Multiplies the specified values.
        /// </summary>
        /// <param name="lhs">The LHS value.</param>
        /// <param name="rhs">The RHS value.</param>
        /// <returns>The division result.</returns>
        public double Execute(double lhs, double rhs)
        {
            return lhs / rhs;
        }
    }
}