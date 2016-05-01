// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DivisionOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

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