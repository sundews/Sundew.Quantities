namespace Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit
{
    using System;

    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Units;

    public abstract class StepsTestBase : IDisposable
    {
        protected readonly FactoredUnit StepsUnit = new FactoredUnit(
            (1 / 53.4323198) / 1000,
            "steps",
            UnitDefinitions.Meter);

        protected StepsTestBase()
        {
            UnitSystem.InitializeWithDefaults(null, unitRegistry => unitRegistry.Register(this.StepsUnit));
        }

        public void Dispose()
        {
            UnitSystem.Reset();
        }
    }
}