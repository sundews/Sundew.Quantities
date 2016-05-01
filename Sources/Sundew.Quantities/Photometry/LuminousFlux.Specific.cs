// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousFlux.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a luminous flux quantity.
    /// </summary>
    public partial class LuminousFlux
    {
        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static LuminousIntensity operator /(LuminousFlux lhs, SolidAngle rhs)
        {
            return new LuminousIntensity(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Illuminance operator /(LuminousFlux lhs, Area rhs)
        {
            return new Illuminance(QuantityOperations.Divide(lhs, rhs));
        }
    }
}