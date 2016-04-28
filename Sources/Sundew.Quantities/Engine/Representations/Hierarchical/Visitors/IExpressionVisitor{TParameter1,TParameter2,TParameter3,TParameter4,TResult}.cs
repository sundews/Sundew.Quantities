namespace Sundew.Quantities.Engine.Representations.Hierarchical.Visitors
{
    using Sundew.Base.Visiting;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing the an expression visitor with four parameters.
    /// </summary>
    /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
    /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
    /// <typeparam name="TParameter3">The type of the parameter3.</typeparam>
    /// <typeparam name="TParameter4">The type of the parameter4.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IExpressionVisitor<in TParameter1, in TParameter2, in TParameter3, in TParameter4, out TResult> : IVisitor<Expression, TParameter1, TParameter2, TParameter3, TParameter4, TResult>
    {
        /// <summary>
        /// Visits a <see cref="MultiplicationExpression"/>.
        /// </summary>
        /// <param name="multiplicationExpression">The multiplication expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Multiply(MultiplicationExpression multiplicationExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Visits a <see cref="DivisionExpression"/>.
        /// </summary>
        /// <param name="divisionExpression">The division expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Divide(DivisionExpression divisionExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Visits a <see cref="MagnitudeExpression"/>.
        /// </summary>
        /// <param name="magnitudeExpression">The magnitude expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Magnitude(MagnitudeExpression magnitudeExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Visits a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="parenthesisExpression">The parentheses expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Parenthesis(ParenthesisExpression parenthesisExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Visits a <see cref="UnitExpression"/>.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Unit(UnitExpression unitExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Visits a <see cref="VariableExpression"/>.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Variable(VariableExpression variableExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Visits a <see cref="ConstantExpression"/>.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        void Constant(ConstantExpression constantExpression, TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);
    }
}