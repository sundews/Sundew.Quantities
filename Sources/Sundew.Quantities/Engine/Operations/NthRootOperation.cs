// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="NthRootOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
{
    using System;

    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Nth root operation for <see cref="IQuantity"/> instance.
    /// </summary>
    public class NthRootOperation : IQuantityOperation<double>
    {
        private readonly IExpressionReducer expressionReducer;

        private readonly IUnitFactory unitFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="NthRootOperation"/> class.
        /// </summary>
        /// <param name="unitFactory">The unit factory.</param>
        /// <param name="expressionReducer">The expression reducer.</param>
        public NthRootOperation(IUnitFactory unitFactory, IExpressionReducer expressionReducer)
        {
            this.unitFactory = unitFactory;
            this.expressionReducer = expressionReducer;
        }

        /// <summary>
        /// Executes the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS value.</param>
        /// <returns>A <see cref="IQuantity"/>.</returns>
        public IQuantity Execute(IQuantity lhs, double rhs)
        {
            var reciprocal = 1 / rhs;
            var magnitudeExpression = new MagnitudeExpression(
                lhs.Unit.GetExpression(),
                new ConstantExpression(reciprocal));
            return new Quantity(
                Math.Pow(lhs.Value, rhs),
                this.unitFactory.Create(this.expressionReducer.Reduce(magnitudeExpression, true)));
        }
    }
}