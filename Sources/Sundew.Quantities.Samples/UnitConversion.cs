// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitConversion.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Samples
{
    using Sundew.Quantities.Spatial;

    using Xunit;
    using Xunit.Abstractions;

    public class UnitConversion
    {
        public UnitConversion(ITestOutputHelper output)
        {
            this.output = output;
        }

        private readonly ITestOutputHelper output;

        [Fact(Skip = "Sample")]
        public void ConvertDistance()
        {
            #region UsageDistance

            // Create kilo meters
            var kilometers = 4.ToDistance(x => x.Kilo.Meters);

            // Create miles
            var miles = kilometers.ToUnit(x => x.Miles);

            this.output.WriteLine(kilometers + " is " + miles);
            // 4 [km] is 2,48548476894934 [mi]

            #endregion
        }

        [Fact(Skip = "Sample")]
        public void ConvertVolume()
        {
            #region UsageVolume

            // Create cubic meters
            var m3 = 4.ToVolume(x => x.Cubic.Meters);

            // Convert to liters
            var l = m3.ToUnit(x => x.Liters);

            this.output.WriteLine(m3 + " is " + l);
            // 4 [m³] is 4000 [L]

            #endregion
        }
    }
}