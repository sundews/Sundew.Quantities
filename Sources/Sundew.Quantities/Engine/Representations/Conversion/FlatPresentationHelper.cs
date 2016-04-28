namespace Sundew.Quantities.Engine.Representations.Conversion
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

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