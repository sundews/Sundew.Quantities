// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExpressionTestHelper.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;

    internal static class ExpressionTestHelper
    {
        public static readonly UnitExpression Xray = new UnitExpression(new Unit("X"));

        public static readonly UnitExpression Yankee = new UnitExpression(new Unit("Y"));

        public static readonly UnitExpression Zulu = new UnitExpression(new Unit("Z"));

        public static UnitSystem CreateUnitSystem()
        {
            var unitSystem = new UnitSystem();
            unitSystem.InitializeUnitSystemWithDefaults();

            return unitSystem;
        }
    }
}