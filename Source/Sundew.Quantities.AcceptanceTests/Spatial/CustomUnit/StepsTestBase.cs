// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StepsTestBase.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit;

using System;
using Sundew.Quantities.Core;
using Sundew.Quantities.Representations.Units;

public abstract class StepsTestBase : IDisposable
{
    private readonly FactoredUnit stepsUnit = new(
        (1 / 53.4323198) / 1000,
        "steps",
        UnitDefinitions.Meter);

    protected StepsTestBase()
    {
        UnitSystem.InitializeWithDefaults(unitRegistry => unitRegistry.Register(this.StepsUnit));
    }

    protected FactoredUnit StepsUnit => this.stepsUnit;

    public void Dispose()
    {
        UnitSystem.Reset();
    }
}