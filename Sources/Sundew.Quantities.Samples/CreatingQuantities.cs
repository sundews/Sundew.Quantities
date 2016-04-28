namespace Sundew.Quantities.Samples
{
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Spacetime;
    using Sundew.Quantities.Spatial;

    using Xunit;
    using Xunit.Abstractions;

    public class CreatingQuantities
    {
        private readonly ITestOutputHelper output;

        public CreatingQuantities(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(Skip = "Sample")]
        public void CreateDistance()
        {
            #region UsageDistance
            // Extension method for the distance base unit (Meters).
            var meters = 4.Meters();

            // Extension method with a unit selector for selecting any unit.
            var kilometers = 5.ToDistance(x => x.Kilo.Meters);

            // Same as above, but as a direct call to the constructor.
            var micrometers = new Distance(6, x => x.Micro.Meters);

            // Constructor, which accepts any IUnit (Primarily used by serialization).
            var millimeters = new Distance(7, UnitSystem.GetUnitFrom("mm", ParseSettings.DefaultInvariantCulture).Value);

            this.output.WriteLine(meters);
            this.output.WriteLine(kilometers);
            this.output.WriteLine(micrometers);
            this.output.WriteLine(millimeters);

            // 4 [m]
            // 5 [km]
            // 6 [μm]
            // 7 [mm]
            #endregion
        }

        [Fact(Skip = "Sample")]
        public void CreateAcceleration()
        {
            #region UsageAcceleration
            // Extension method for the acceleration base unit (m/s^2).
            var mps2 = 4.MetersPerSecondSquared();

            // Extension method with a unit selector for selecting any unit.
            var kmph2 = 5.ToAcceleration(x => x.Kilo.Meters / x.Square.Hours);

            // Same as above, but as a direct call to the constructor.
            var miphps = new Acceleration(6, x => x.Miles / x.Hours / x.Seconds);

            // Constructor, which accepts any IUnit (Primarily used by serialization).
            var mmps2 = new Acceleration(7, UnitSystem.GetUnitFrom("mm/s²", ParseSettings.DefaultInvariantCulture).Value);

            this.output.WriteLine(mps2);
            this.output.WriteLine(kmph2);
            this.output.WriteLine(miphps);
            this.output.WriteLine(mmps2);

            // 4 [m/s²]
            // 5 [km/h²]
            // 6 [mi/h/s]
            // 7 [mm/s²]
            #endregion
        }
    }
}