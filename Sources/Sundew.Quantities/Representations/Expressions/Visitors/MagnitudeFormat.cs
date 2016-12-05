// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagnitudeFormat.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Representations.Expressions.Visitors
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