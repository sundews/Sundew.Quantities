// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionTestHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests
{
    using Sundew.Quantities.Core;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;

    internal static class ExpressionTestHelper
    {
        public static readonly UnitExpression Xray = new(new Unit("X"));

        public static readonly UnitExpression Yankee = new(new Unit("Y"));

        public static readonly UnitExpression Zulu = new(new Unit("Z"));

        public static UnitSystem CreateUnitSystem()
        {
            var unitSystem = new UnitSystem();
            unitSystem.InitializeUnitSystemWithDefaults();

            return unitSystem;
        }
    }
}