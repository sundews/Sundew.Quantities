// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IExpressionVisitor{TParameter,TResult}.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing the an expression visitor with one parameter.
    /// </summary>
    /// <typeparam name="TParameter">The type of the parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IExpressionVisitor<in TParameter, out TResult> : IVisitor<Expression, TParameter, TResult>
    {
        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Multiply(MultiplicationExpression multiplicationExpression, TParameter parameter);

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Divide(DivisionExpression divisionExpression, TParameter parameter);

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Magnitude(MagnitudeExpression magnitudeExpression, TParameter parameter);

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Parenthesis(ParenthesisExpression parenthesisExpression, TParameter parameter);

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Unit(UnitExpression unitExpression, TParameter parameter);

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Variable(VariableExpression variableExpression, TParameter parameter);

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="parameter">The parameter.</param>
        void Constant(ConstantExpression constantExpression, TParameter parameter);
    }
}