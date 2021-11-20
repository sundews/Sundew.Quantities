// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MathML.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Formatters.MathML
{
    using System.Xml.Linq;

    /// <summary>
    /// Contains values related to MathML.
    /// </summary>
    public static class MathML
    {
        /// <summary>
        /// The multiplication cross
        /// </summary>
        public const string MultiplicationCross = "×";

        /// <summary>
        /// The multiplication invisible
        /// </summary>
        public const string MultiplicationInvisible = "\x2062";

        /// <summary>
        /// The multiplication dot
        /// </summary>
        public const string MultiplicationDot = "·";

        /// <summary>
        /// The multiplication star
        /// </summary>
        public const string MultiplicationStar = "*";

        /// <summary>
        /// The MathML namespace
        /// </summary>
        public static readonly XNamespace Namespace = "http://www.w3.org/1998/Math/MathML";

        /// <summary>
        /// The namespace alias
        /// </summary>
        public static readonly XName NamespaceAlias = XNamespace.Xmlns + "mml";

        /// <summary>
        /// The math xname.
        /// </summary>
        public static readonly XName Math = Namespace + "math";

        /// <summary>
        /// The mo xname.
        /// </summary>
        public static readonly XName Mo = Namespace + "mo";

        /// <summary>
        /// The mrow xname.
        /// </summary>
        public static readonly XName Mrow = Namespace + "mrow";

        /// <summary>
        /// The mfrac xname.
        /// </summary>
        public static readonly XName Mfrac = Namespace + "mfrac";

        /// <summary>
        /// The msup xname.
        /// </summary>
        public static readonly XName Msup = Namespace + "msup";

        /// <summary>
        /// The mi xname.
        /// </summary>
        public static readonly XName Mi = Namespace + "mi";

        /// <summary>
        /// The mn xname.
        /// </summary>
        public static readonly XName Mn = Namespace + "mn";

        /// <summary>
        /// The math variant normal
        /// </summary>
        public static readonly XAttribute MathVariantNormal = new("mathvariant", "normal");

        /// <summary>
        /// The class unit
        /// </summary>
        public static readonly XAttribute ClassUnit = new("class", "MathML-Unit");

        /// <summary>
        /// The mfenced xname.
        /// </summary>
        public static readonly XName Mfenced = Namespace + "mfenced";

        /// <summary>
        /// The open left bracket.
        /// </summary>
        public static readonly XAttribute OpenLeftBracket = new("open", "[");

        /// <summary>
        /// The close right brack.
        /// </summary>
        public static readonly XAttribute CloseRightBrack = new("close", "]");

        /// <summary>
        /// Gets the multiplication sign as a string.
        /// </summary>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <returns>The multiplication sign as a string.</returns>
        public static string GetMultiplicationSign(MultiplicationSign multiplicationSign)
        {
            return multiplicationSign switch
            {
                MultiplicationSign.Dot => MultiplicationDot,
                MultiplicationSign.Star => MultiplicationStar,
                MultiplicationSign.Cross => MultiplicationCross,
                _ => MultiplicationInvisible
            };
        }
    }
}