// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConvertToUnitOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core.Operations;

using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Convert to unit operation for <see cref="IQuantity"/> instance.
/// </summary>
public class ConvertToUnitOperation : IQuantityAndUnitOperation
{
    /// <summary>
    /// Executes the operation.
    /// </summary>
    /// <param name="lhs">The LHS quantity.</param>
    /// <param name="rhs">The RHS quantity.</param>
    /// <returns>
    /// The resulting value.
    /// </returns>
    public double Execute(IQuantity lhs, IUnit rhs)
    {
        var valueUnit = lhs.Unit;
        var value = lhs.Value;
        if (!UnitEqualityHelper.AreUnitsEqual(valueUnit, rhs))
        {
            value = rhs.FromBase(valueUnit.ToBase(value));
        }

        return value;
    }
}