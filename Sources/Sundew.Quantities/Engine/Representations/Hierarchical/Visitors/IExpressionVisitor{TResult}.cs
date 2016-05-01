// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IExpressionVisitor{TResult}.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing the an expression visitor without any parameters.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IExpressionVisitor<out TResult> : IVisitor<Expression, TResult>
    {
        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        void Multiply(MultiplicationExpression multiplicationExpression);

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        void Divide(DivisionExpression divisionExpression);

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        void Magnitude(MagnitudeExpression magnitudeExpression);

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        void Parentheses(ParenthesisExpression parenthesisExpression);

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        void Unit(UnitExpression unitExpression);

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        void Variable(VariableExpression variableExpression);

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        void Constant(ConstantExpression constantExpression);
    }
}