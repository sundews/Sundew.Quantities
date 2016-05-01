// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExponentialNotationToDerivedUnitOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    /// <summary>
    /// Operation for getting a <see cref="DerivedUnit"/> after executing an <see cref="IUnitOperation{ReductionResult}"/>.
    /// </summary>
    public class UnitOperationToDerivedUnitOperation : IUnitOperation<DerivedUnit>
    {
        private readonly IUnitFactory unitFactory;

        private readonly IUnitOperation<ReductionResult> unitOperation;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOperationToDerivedUnitOperation"/> class.
        /// </summary>
        /// <param name="unitFactory">The unit factory.</param>
        /// <param name="unitOperation">The unit operation.</param>
        public UnitOperationToDerivedUnitOperation(
            IUnitFactory unitFactory,
            IUnitOperation<ReductionResult> unitOperation)
        {
            this.unitFactory = unitFactory;
            this.unitOperation = unitOperation;
        }

        /// <summary>
        /// Executes the operation.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <param name="isReducingByBaseUnits">If set to <c>true</c> reduction will be done with base units.</param>
        /// <returns>
        /// A <see cref="DerivedUnit"/>.
        /// </returns>
        public DerivedUnit Execute(IUnit lhs, IUnit rhs, bool isReducingByBaseUnits)
        {
            var result = this.unitOperation.Execute(lhs, rhs, isReducingByBaseUnits);
            return this.unitFactory.CreateDerivedUnit(result);
        }
    }
}