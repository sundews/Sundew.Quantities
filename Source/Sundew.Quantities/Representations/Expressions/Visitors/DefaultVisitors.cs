// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultVisitors.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors
{
    /// <summary>
    /// Contains default visitors used for <see cref="System.Linq.Expressions.Expression"/>s.
    /// </summary>
    public static class DefaultVisitors
    {
        /// <summary>
        /// To base visitor.
        /// </summary>
        public static readonly ValueToBaseVisitor ValueToBaseVisitor = new();

        /// <summary>
        /// From base visitor.
        /// </summary>
        public static readonly ValueFromBaseVisitor ValueFromBaseVisitor = new();

        /// <summary>
        /// The prefix visitor.
        /// </summary>
        public static readonly PrefixVisitor PrefixVisitor = new();

        /// <summary>
        /// The notation visitor.
        /// </summary>
        public static readonly NotationVisitor NotationVisitor = new(NotationOptions.Default);

        /// <summary>
        /// The base expression visitor.
        /// </summary>
        public static readonly BaseExpressionVisitor BaseExpressionVisitor = new();
    }
}