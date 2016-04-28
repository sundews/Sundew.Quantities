namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using System;

    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit;
    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class CustomUnitTests : StepsTestBase
    {
        [Fact]
        public void CustomUnitToUnit_Then_ResultShouldBeExpected()
        {
            var steps = new Quantity(43, this.StepsUnit);
            const double Expected = 0.00080475637518549213354573461734671;

            var result = steps.ToUnit(UnitDefinitions.Meter);

            result.Should().BeApproximately(Expected, "m", TestHelper.DefaultAssertPrecision);
        }
    }
}