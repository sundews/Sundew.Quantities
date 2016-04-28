namespace Sundew.Quantities.Samples
{
    using Sundew.Quantities.Electromagnetism;
    using Sundew.Quantities.Mechanics;
    using Sundew.Quantities.Periodics;
    using Sundew.Quantities.Spatial;

    using Xunit;
    using Xunit.Abstractions;

    public class Operations
    {
        private readonly ITestOutputHelper output;

        public Operations(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(Skip = "Sample")]
        public void SpacetimeOperations()
        {
            #region UsageSpacetime
            // Create distance
            var distance = 30.Meters();
            // Create time1
            var time1 = 3.Seconds();

            // Calculate velocity
            var velocity1 = distance / time1;

            // Create time2
            var time2 = 2.Seconds();

            // Calculate acceleration
            var acceleration = velocity1 / time2;

            // Create time3
            var time3 = 30.Seconds();

            // Calculate velocity2
            var velocity2 = acceleration * time3;

            // Create time4
            var time4 = 60.Seconds();

            // Calculate distance2
            var distance2 = velocity2 * time4;

            this.output.WriteLine(distance  + " / " + time1 + " = " + velocity1);
            this.output.WriteLine(velocity1 + " / " + time2 + " = " + acceleration);
            this.output.WriteLine(acceleration + " * " + time3 + " = " + velocity2);
            this.output.WriteLine(velocity2 + " * " + time4 + " = " + distance2);

            // 30 [m] / 3 [s] = 10 [m/s]
            // 10 [m/s] / 2 [s] = 5 [m/s²]
            // 5 [m/s²] * 30 [s] = 150 [m/s]
            // 150 [m/s] * 60 [s] = 9000 [m]
            #endregion
        }

        [Fact(Skip = "Sample")]
        public void ElectromagnetismOperations()
        {
            #region UsageElectromagnetism
            // Create potential
            var potential = 12.Volts();
            // Create electric current
            var electricCurrent1 = 2.Amperes();

            // Calculate power
            var power1 = potential * electricCurrent1;

            // Create power2
            var power2 = 1600.ToPower(x => x.Milli.Watts);

            // Sum of power
            var power3 = power1 + power2;

            // Difference of power
            var power4 = power2 - power1;

            // Create resistance
            var resistance = 4.Ohms();

            // Calculate electric current
            var electricCurrent2 = potential / resistance;

            this.output.WriteLine(potential + " * " + electricCurrent1 + " = " + power1);
            this.output.WriteLine(power1 + " + " + power2 + " = " + power3);
            this.output.WriteLine(power2 + " - " + power1 + " = " + power4);
            this.output.WriteLine(potential + " / " + resistance + " = " + electricCurrent2);

            // 12 [V] * 2 [A] = 24 [W]
            // 24 [W] + 1600 [mW] = 25,6 [W]
            // 1600 [mW] - 24 [W] = -22400 [mW]
            // 12 [V] / 4 [Ω] = 3 [A]
            #endregion
        }
    }
}