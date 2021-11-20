// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityToMathMLConverter.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Formatters.MathML
{
    using System.Xml.Linq;
    using Sundew.Quantities.Core;

    /// <summary>
    /// Converter for converting quantities to MathML.
    /// </summary>
    public sealed class QuantityToMathMLConverter
    {
        /// <summary>
        /// The default converter.
        /// </summary>
        public static readonly QuantityToMathMLConverter DefaultConverter = new();

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