// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Pressure.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a pressure quantity.
    /// </summary>
    public partial class Pressure
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product.</returns>
        public static Energy operator *(Pressure lhs, Volume rhs)
        {
            return new Energy(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}