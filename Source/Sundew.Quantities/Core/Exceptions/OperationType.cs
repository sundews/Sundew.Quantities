// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperationType.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Core.Exceptions
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