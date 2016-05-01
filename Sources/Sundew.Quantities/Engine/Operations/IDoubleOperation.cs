// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IDoubleOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
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