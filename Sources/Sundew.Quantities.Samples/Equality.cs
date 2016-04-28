namespace Sundew.Quantities.Samples
{
    using Sundew.Quantities.Thermodynamics;

    using Xunit;
    using Xunit.Abstractions;

    public class Equality
    {
        private readonly ITestOutputHelper output;

        public Equality(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(Skip = "Sample")]
        public void TemperatureEquality()
        {
            #region UsageTemperatureEquality
            // Create temperature1
            var temperature1 = -4.Celsius();

            // Create temperature2
            var temperature2 = 269.15.Kelvin();

            // Create temperature3
            var temperature3 = -4.ToTemperature(x => x.Fahrenheits);

            // Check for equality
            var temperature12Equals = temperature1.Equals(temperature2);

            // Check for equality
            var temperature13Equals = temperature1.Equals(temperature3);

            this.output.WriteLine(temperature1 + " is" + (temperature12Equals ? " " :  " not ") + "equal to " + temperature2);
            this.output.WriteLine(temperature1 + " is" + (temperature13Equals ? " " :  " not ") + "equal to " + temperature3);

            // -4 [°C] is equal to 269,15 [K]
            // -4 [°C] is not equal to -4 [°F]
            #endregion
        }
    }
}