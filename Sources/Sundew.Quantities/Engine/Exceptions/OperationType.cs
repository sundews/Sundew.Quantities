// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="OperationType.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Exceptions
{
    /// <summary>
    /// Enumeration for identifying a failing operation.
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// The compare operation.
        /// </summary>
        Compare,

        /// <summary>
        /// The add operation.
        /// </summary>
        Add,

        /// <summary>
        /// The subtract operation.
        /// </summary>
        Subtract
    }
}