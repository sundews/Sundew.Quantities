// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExpressionTestHelper.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Units;

namespace Sundew.Quantities.UnitTests.Engine
{
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