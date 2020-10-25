// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Representations.Internals
{
    internal static class Constants
    {
        public const string ValueAndUnitFormat = Arg0 + " " + Arg1;

        public const string PrefixAndUnitFormat = Arg0 + Arg1;

        public const string MultiplicationFormat = Arg0 + Multiply + Arg1;

        public const string DivisionFormat = Arg0 + Divide + Arg1;

        public const string Add = "+";

        public const string Subtract = "-";

        public const string Multiply = "*";

        public const string MultiplyDot = "·";

        public const string MultiplyCross = "×";

        public const string Divide = "/";

        public const string Power = "^";

        public const string LeftWeakParenthesis = "{";

        public const string RightWeakParenthesis = "}";

        public const string LeftParenthesis = "(";

        public const string RightParenthesis = ")";

        public const string Degree = "°";

        public const string Arg0 = "{0}";

        public const string Arg1 = "{1}";

        public const char Exponent0 = '⁰';

        public const char Exponent1 = '¹';

        public const char Exponent2 = '²';

        public const char Exponent3 = '³';

        public const char Exponent4 = '⁴';

        public const char Exponent5 = '⁵';

        public const char Exponent6 = '⁶';

        public const char Exponent7 = '⁷';

        public const char Exponent8 = '⁸';

        public const char Exponent9 = '⁹';

        public const char DotAbove = '˙';

        public const char CommaAbove = '̒';

        public const char SuperScriptMinus = '⁻';

        public const char LeftParentheseAbove = '⁽';

        public const char RightParentheseAbove = '⁾';
    }
}