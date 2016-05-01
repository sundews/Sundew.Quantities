// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Illuminance.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents a illuminance quantity.
    /// </summary>
    public partial class Illuminance
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Product<Illuminance, Time> operator *(Illuminance lhs, Time rhs)
        {
            return new Product<Illuminance, Time>(lhs, rhs);
        }
    }
}