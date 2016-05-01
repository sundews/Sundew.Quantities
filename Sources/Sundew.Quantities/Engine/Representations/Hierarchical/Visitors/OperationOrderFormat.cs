// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="OperationOrderFormat.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    /// <summary>
    /// Specifies the operation order format.
    /// </summary>
    public enum OperationOrderFormat
    {
        /// <summary>
        /// No operation order will be shown.
        /// </summary>
        None,

        /// <summary>
        /// Curly Brackets will indicate precedence.
        /// </summary>
        CurlyBrackets,

        /// <summary>
        /// Parentheses will indicate the order.
        /// </summary>
        Parentheses,
    }
}