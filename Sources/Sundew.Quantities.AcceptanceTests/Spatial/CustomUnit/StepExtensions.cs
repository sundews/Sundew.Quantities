// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StepExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Sundew.Quantities.UnitSelectors;

    public static class StepExtensions
    {
        public static Expression Steps(this IDistanceUnitSelector distanceUnitSelector)
        {
            return
                new DerivedUnit(new ConstantExpression((1 / 53.4323198) / 1000) * UnitDefinitions.Meter).GetExpression();
        }
    }
}