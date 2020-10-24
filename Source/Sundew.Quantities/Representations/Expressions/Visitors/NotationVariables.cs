// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotationVariables.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions.Visitors
{
    /// <summary>
    /// Contains the variables required for the <see cref="NotationVisitor"/>.
    /// </summary>
    public sealed class NotationVariables
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotationVariables" /> class.
        /// </summary>
        /// <param name="requestPrecedence">If set to <c>true</c> precedence is requested.</param>
        public NotationVariables(bool requestPrecedence)
            : this(requestPrecedence, false)
        {
        }

        internal NotationVariables(bool requestPrecedence, bool expressionIsChild)
        {
            this.RequestPrecedence = requestPrecedence;
            this.ExpressionIsChild = expressionIsChild;
        }

        /// <summary>
        /// Gets a value indicating whether precedence is requested.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [request precedence]; otherwise, <c>false</c>.
        /// </value>
        public bool RequestPrecedence { get; }

        /// <summary>
        /// Gets a value indicating whether expression is a child.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [expression is child]; otherwise, <c>false</c>.
        /// </value>
        public bool ExpressionIsChild { get; }
    }
}