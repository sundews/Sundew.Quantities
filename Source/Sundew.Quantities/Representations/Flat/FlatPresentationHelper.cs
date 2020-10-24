// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatPresentationHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Flat
{
    using System;
    using Sundew.Quantities.Representations.Expressions;

    internal static class FlatPresentationHelper
    {
        public static readonly int HatHashCode = "^".GetHashCode();

        public static Expression CreateResultingExpression(Expression expression, double exponent)
        {
            if (exponent.Equals(0.0))
            {
                return null;
            }

            exponent = Math.Abs(exponent);
            if (exponent.Equals(1.0))
            {
                return expression;
            }

            return new MagnitudeExpression(expression, new ConstantExpression(exponent));
        }
    }
}