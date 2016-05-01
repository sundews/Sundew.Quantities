// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagneticFlux.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Spatial;

    /// <summary>
    /// Represents a magnetic flux quantity.
    /// </summary>
    public partial class MagneticFlux
    {
        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Inductance operator /(MagneticFlux lhs, ElectricCurrent rhs)
        {
            return new Inductance(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static MagneticFluxDensity operator /(MagneticFlux lhs, Area rhs)
        {
            return new MagneticFluxDensity(QuantityOperations.Divide(lhs, rhs));
        }
    }
}