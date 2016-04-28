namespace Sundew.Quantities.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Electromagnetism;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    using Xunit;

    public class ChargeMultiplicationTests
    {
        [Fact]
        public void Charge_Multiplication_Then_ResultShouldBeExpected()
        {
            var testee = new Charge(3, x => x.Coulombs);
            var potential = new Potential(4, x => x.Volts);

            var result = testee * potential;

            result.Should().Be(12, "J", UnitFormat.Default);
        }
    }
}