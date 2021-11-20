// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReducingOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core.Operations;

using Sundew.Quantities.Representations.Evaluation;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// An operation for <see cref="IQuantity{TQuantity}"/> that reduces the units.
/// </summary>
public class ReducingOperation : IQuantityOperation<IQuantity>
{
    private readonly IDoubleOperation doubleOperation;

    private readonly IUnitFactory unitFactory;

    private readonly IUnitOperation<UnitReductionResult> unitOperation;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReducingOperation" /> class.
    /// </summary>
    /// <param name="unitFactory">The unit factory.</param>
    /// <param name="unitOperation">The unit division operation.</param>
    /// <param name="doubleOperation">The double operation.</param>
    public ReducingOperation(
        IUnitFactory unitFactory,
        IUnitOperation<UnitReductionResult> unitOperation,
        IDoubleOperation doubleOperation)
    {
        this.unitFactory = unitFactory;
        this.unitOperation = unitOperation;
        this.doubleOperation = doubleOperation;
    }

    /// <summary>
    /// Executes the specified LHS.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>
    /// A <see cref="Quantity" />.
    /// </returns>
    public IQuantity Execute(IQuantity lhs, IQuantity rhs)
    {
        var lhsValue = lhs.Value;
        var lhsUnit = lhs.Unit;
        var rhsValue = rhs.Value;
        var rhsUnit = rhs.Unit;
        var reductionResult = this.unitOperation.Execute(lhsUnit, rhsUnit, true);
        if (reductionResult.HasReductions)
        {
            rhsValue = reductionResult.ConvertRhs(rhsValue);
            return this.CreateQuantity(lhsValue, rhsValue, this.unitFactory.CreateDerivedUnit(reductionResult));
        }

        var baseReductionResult = this.unitOperation.Execute(lhsUnit.BaseUnit, rhsUnit.BaseUnit, true);
        if (baseReductionResult.HasReductions)
        {
            rhsValue = reductionResult.ConvertRhs(rhsValue);
            reductionResult = baseReductionResult;
        }

        var prefixFactor = this.doubleOperation.Execute(lhsUnit.PrefixFactor, rhsUnit.PrefixFactor);

        IUnit unit = this.unitFactory.CreateDerivedUnit(baseReductionResult, reductionResult);
        if (prefixFactor.Equals(1.0) || unit.PrefixFactor.Equals(prefixFactor))
        {
            return this.CreateQuantity(lhsValue, rhsValue, unit);
        }

        unit = this.unitFactory.CreatePrefixedUnit(unit, prefixFactor);
        return this.CreateQuantity(lhsValue, rhsValue, unit);
    }

    private Quantity CreateQuantity(double lhsValue, double rhsValue, IUnit unit)
    {
        return new Quantity(this.doubleOperation.Execute(lhsValue, rhsValue), unit);
    }
}