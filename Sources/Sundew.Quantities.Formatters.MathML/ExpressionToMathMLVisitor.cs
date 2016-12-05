// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExpressionToMathMLVisitor.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations.Expressions;

namespace Sundew.Quantities.Formatters.MathML
{
    using System.Xml.Linq;

    #region UsageMathML

    /// <summary>
    /// Implements an <see cref="IExpressionVisitor{TParameter1,TParameter2,TResult}"/> for converting <see cref="Expression"/>s to MathML.
    /// </summary>
    public class ExpressionToMathMLVisitor : IExpressionVisitor<MultiplicationSign, XElement, XElement>
    {
        private const string LeftParenthesis = "(";

        private const string RightParenthesis = ")";

        /// <summary>
        /// The default math ml visitor
        /// </summary>
        public static readonly ExpressionToMathMLVisitor DefaultMathMLVisitor = new ExpressionToMathMLVisitor();

        /// <summary>
        /// Visits the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        /// <returns>The root element.</returns>
        public XElement Visit(
            Expression expression,
            MultiplicationSign multiplicationSign = MultiplicationSign.Dot,
            XElement xElement = null)
        {
            var root = xElement;
            if (root == null || xElement.Name.NamespaceName != MathML.Namespace.NamespaceName)
            {
                root = new XElement(MathML.Math, new XAttribute(MathML.NamespaceAlias, MathML.Namespace));
                xElement?.Add(root);
            }

            expression.Visit(this, multiplicationSign, root);
            return root;
        }

        /// <summary>
        /// Adds a mo tag and visits the lhs and rhs expression.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Multiply(
            MultiplicationExpression multiplicationExpression,
            MultiplicationSign multiplicationSign,
            XElement xElement)
        {
            multiplicationExpression.Lhs.Visit(this, multiplicationSign, xElement);
            xElement.Add(new XElement(MathML.Mo, MathML.GetMultiplicationSign(multiplicationSign)));
            multiplicationExpression.Rhs.Visit(this, multiplicationSign, xElement);
        }

        /// <summary>
        /// Adds a mfrac tag with two mrow tags and visits the lhs and rhs expression.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Divide(
            DivisionExpression divisionExpression,
            MultiplicationSign multiplicationSign,
            XElement xElement)
        {
            var nominator = new XElement(MathML.Mrow);
            var denominator = new XElement(MathML.Mrow);
            var fraction = new XElement(MathML.Mfrac, nominator, denominator);
            xElement.Add(fraction);
            divisionExpression.Lhs.Visit(this, multiplicationSign, nominator);
            divisionExpression.Rhs.Visit(this, multiplicationSign, denominator);
        }

        /// <summary>
        /// Adds a msup tag and visits the lhs and rhs expression.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Magnitude(
            MagnitudeExpression magnitudeExpression,
            MultiplicationSign multiplicationSign,
            XElement xElement)
        {
            var magnitude = new XElement(MathML.Msup);
            xElement.Add(magnitude);
            magnitudeExpression.Lhs.Visit(this, multiplicationSign, magnitude);
            magnitudeExpression.Rhs.Visit(this, multiplicationSign, magnitude);
        }

        /// <summary>
        /// Adds mo tags for the parethesis and visits the child expression.
        /// </summary>
        /// <param name="parenthesisExpression">The parenthesis expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Parenthesis(
            ParenthesisExpression parenthesisExpression,
            MultiplicationSign multiplicationSign,
            XElement xElement)
        {
            var mrow = new XElement(MathML.Mrow);
            xElement.Add(mrow);
            mrow.Add(new XElement(MathML.Mo, LeftParenthesis));
            parenthesisExpression.Expression.Visit(this, multiplicationSign, mrow);
            mrow.Add(new XElement(MathML.Mo, RightParenthesis));
        }

        /// <summary>
        /// Adds a <see cref="UnitExpression"/> via the mi tag.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Unit(UnitExpression unitExpression, MultiplicationSign multiplicationSign, XElement xElement)
        {
            xElement.Add(new XElement(MathML.Mi, unitExpression.Unit, MathML.MathVariantNormal, MathML.ClassUnit));
        }

        /// <summary>
        /// Adds a <see cref="VariableExpression"/> via the mi tag.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Variable(
            VariableExpression variableExpression,
            MultiplicationSign multiplicationSign,
            XElement xElement)
        {
            xElement.Add(new XElement(MathML.Mi, variableExpression.VariableName));
        }

        /// <summary>
        /// Adds a <see cref="ConstantExpression"/> via the mn tag.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <param name="xElement">The x element.</param>
        public void Constant(
            ConstantExpression constantExpression,
            MultiplicationSign multiplicationSign,
            XElement xElement)
        {
            xElement.Add(new XElement(MathML.Mn, constantExpression.Constant));
        }
    }

    #endregion
}