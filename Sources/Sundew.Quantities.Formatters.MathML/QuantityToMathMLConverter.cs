// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityToMathMLConverter.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Formatters.MathML
{
    using System.Xml.Linq;
    using Sundew.Quantities.Core;

    /// <summary>
    /// 
    /// </summary>
    public sealed class QuantityToMathMLConverter
    {
        public static readonly QuantityToMathMLConverter DefaultConverter = new QuantityToMathMLConverter();

        /// <summary>
        /// Gets the math ml.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="unitFormat">The unit format.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <returns>The root <see cref="XElement"/> node.</returns>
        public XElement GetMathML(
            IQuantity quantity,
            UnitFormat unitFormat = UnitFormat.Default,
            MultiplicationSign multiplicationSign = MultiplicationSign.Invisible)
        {
            var mn = new XElement(MathML.Mn, quantity.Value);
            var mrow = new XElement(MathML.Mrow, mn);
            var unitElement = mrow;
            if (unitFormat.HasFlag(UnitFormat.SurroundInBrackets))
            {
                var mfenced = new XElement(MathML.Mfenced, MathML.OpenLeftBracket, MathML.CloseRightBrack);
                mrow.Add(mfenced);
                unitElement = mfenced;
            }

            ExpressionToMathMLVisitor.DefaultMathMLVisitor.Visit(
                quantity.Unit.GetExpression(),
                multiplicationSign,
                unitElement);
            return new XElement(MathML.Math, new XAttribute(MathML.NamespaceAlias, MathML.Namespace), mrow);
        }
    }
}