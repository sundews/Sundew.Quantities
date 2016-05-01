// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Steps.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Spatial.UnitSelection;

    public static class StepExtensions
    {
        public static Expression Steps(this IDistanceUnitSelector distanceUnitSelector)
        {
            return
                new DerivedUnit(new ConstantExpression((1 / 53.4323198) / 1000) * UnitDefinitions.Meter).GetExpression();
        }
    }
}