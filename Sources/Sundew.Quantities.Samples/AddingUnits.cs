// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AddingNewUnits.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Samples
{
    using Sundew.Quantities.Core;
    using Sundew.Quantities.Representations.Units;
    using Xunit;

    public class AddingUnits
    {
        [Fact(Skip = "Sample")]
        public void AddNewUnits()
        {
            #region UsageRegisterUnits
            // Only units registered in the code below will be supported by the unit systems.
            // If it is desired to use the default units and add/remove additional unit, use the UnitSystem.InitializeWithDefaults method instead.
            UnitSystem.Initialize(unitRegistrar =>
                    {
                        // Register base unit meters.
                        var meters = new Unit("m");
                        unitRegistrar.Register(meters);

                        // Register base unit seconds.
                        var seconds = new Unit("s");
                        unitRegistrar.Register(seconds);

                        // Register mile as a factored unit relative to the base unit meter.
                        unitRegistrar.Register(new FactoredUnit(1609.344, "mi", meters));

                        // Register base unit kelvins.
                        var kelvins = new Unit("K");
                        unitRegistrar.Register(kelvins);

                        // Register method unit fahrenheits, with conversion to and from the base unit kelvin.
                        var fahrenheits = new MethodUnit(
                            fahrenheit => ((fahrenheit - 32) / 1.8) + 273.15,
                            kelvin => ((kelvin - 273.15) * 1.8) + 32,
                            "°F",
                            kelvins);
                        unitRegistrar.Register(fahrenheits);

                        // Register special base unit Kilograms (Prefixed base unit)
                        var kilograms = new PrefixedBaseUnit(Prefixes.Kilo, "g");
                        unitRegistrar.Register(kilograms);

                        // Register derived unit newtons, by specifying the base unit expression.
                        var newtons = new DerivedUnit("N", kilograms * meters / seconds.Exp(2));
                        unitRegistrar.Register(newtons);
                    });

            #endregion
        }
    }
}