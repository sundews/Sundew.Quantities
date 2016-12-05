// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Formatters.MathML
{
    using System.Xml.Linq;
    using Sundew.Quantities.Core;

    /// <summary>
    /// Extends <see cref="IQuantity"/> with math ml functionality.
    /// </summary>
    public static class QuantityExtensions
    {
        /// <summary>
        /// Gets the math ml.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="unitFormat">The unit format.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <returns>The root math ml element.</returns>
        public static XElement ToMathML(
            this IQuantity quantity,
            UnitFormat unitFormat = UnitFormat.Default,
            MultiplicationSign multiplicationSign = MultiplicationSign.Invisible)
        {
            return QuantityToMathMLConverter.DefaultConverter.GetMathML(quantity, unitFormat, multiplicationSign);
        }

        /// <summary>
        /// Gets the math ml as a string.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="unitFormat">The unit format.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <returns></returns>
        public static string ToMathMLString(
            this IQuantity quantity,
            UnitFormat unitFormat = UnitFormat.Default,
            MultiplicationSign multiplicationSign = MultiplicationSign.Invisible)
        {
            return
                QuantityToMathMLConverter.DefaultConverter.GetMathML(quantity, unitFormat, multiplicationSign)
                    .ToString();
        }
    }
}