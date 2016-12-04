// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TokenType.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    /// <summary>
    /// Indicates the type of a token.
    /// </summary>
    public enum TokenType
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        Identifier,

        /// <summary>
        /// The number.
        /// </summary>
        Number,

        /// <summary>
        /// The operator.
        /// </summary>
        Operator,

        /// <summary>
        /// The exponent.
        /// </summary>
        Exponent,

        /// <summary>
        /// The white space
        /// </summary>
        WhiteSpace,

        /// <summary>
        /// The end (Termination).
        /// </summary>
        End
    }
}