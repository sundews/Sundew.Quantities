// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExpressionError.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Parsing.Errors
{
    /// <summary>
    /// Errors for <see cref="UnitExpressionParser"/>.
    /// </summary>
    public enum UnitError
    {
        /// <summary>
        /// The lexical analysis failed.
        /// </summary>
        LexicalAnalysisFailed,

        /// <summary>
        /// The prefix unit or unit or variable not found.
        /// </summary>
        PrefixUnitOrUnitOrVariableNotFound,

        /// <summary>
        /// The end of data not found.
        /// </summary>
        EndOfDataNotFound
    }
}