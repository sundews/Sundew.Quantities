// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Volume.Specific.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Mechanics;

    /// <summary>
    /// Represents a volume quantity.
    /// </summary>
    public partial class Volume
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Energy operator *(Volume lhs, Pressure rhs)
        {
            return new Energy(QuantityOperations.Multiply(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Distance operator /(Volume lhs, Area rhs)
        {
            return new Distance(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The quotient of the specified LHS and RHS.</returns>
        public static Area operator /(Volume lhs, Distance rhs)
        {
            return new Area(QuantityOperations.Divide(lhs, rhs));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Cubed{TBase}"/> to <see cref="Volume"/>.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Volume(Cubed<Distance> volume)
        {
            return new Volume(volume.GetResult());
        }
    }
}