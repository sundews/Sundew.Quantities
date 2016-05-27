// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousIntensity.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a luminous intensity quantity.
    /// </summary>
    public partial class LuminousIntensity
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static LuminousFlux operator *(LuminousIntensity lhs, SolidAngle rhs)
        {
            return new LuminousFlux(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}