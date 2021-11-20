// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionRewriter.OperandChange.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation;

using System;

/// <summary>
/// The reduction visitor.
/// </summary>
public partial class ExpressionRewriter
{
    [Flags]
    private enum OperandChange
    {
        /// <summary>
        /// The no change.
        /// </summary>
        NoChange = 0,

        /// <summary>
        /// The lhs is null.
        /// </summary>
        LhsIsNull = 1,

        /// <summary>
        /// The rhs is null.
        /// </summary>
        RhsIsNull = 2,

        /// <summary>
        /// The both are null.
        /// </summary>
        BothAreNull = 3,
    }
}