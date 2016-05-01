// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IConvertToAndFromBase.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Units
{
    /// <summary>
    /// Interface for implementing class that can convert value to and from its base value.
    /// </summary>
    public interface IConvertToAndFromBase
    {
        /// <summary>
        /// Converts the specified value into the unit's base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The unit's base value.</returns>
        double ToBase(double value);

        /// <summary>
        /// Converts the specified value from the SI base value into the unit value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The unit's value.</returns>
        double FromBase(double value);
    }
}