// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagnitudeFormat.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    /// <summary>
    /// Specifies the format for magnitudes.
    /// </summary>
    public enum MagnitudeFormat
    {
        /// <summary>
        /// The use above letter (e.g. ³).
        /// </summary>
        UseAboveLetter,

        /// <summary>
        /// The use magnitude operator (^).
        /// </summary>
        UseMagnitudeOperator
    }
}