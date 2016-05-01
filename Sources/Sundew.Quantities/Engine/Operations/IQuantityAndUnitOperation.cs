// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IQuantityAndUnitOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Interface for implementing operations between <see cref="IQuantity"/> and <see cref="IUnit"/>.
    /// </summary>
    public interface IQuantityAndUnitOperation
    {
        /// <summary>
        /// Executes the operation.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS unit.</param>
        /// <returns>The resulting value.</returns>
        double Execute(IQuantity lhs, IUnit rhs);
    }
}