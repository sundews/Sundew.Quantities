// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitExpressionError.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors
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