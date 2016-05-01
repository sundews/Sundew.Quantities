// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatRepresentationBuilderWithReductionsTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Conversion
{
    using FluentAssertions;

    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.UnitTests.Engine.Representations.Flat;

    using Xunit;

    public class FlatRepresentationBuilderWithReductionsTests
    {
        public FlatRepresentationBuilderWithReductionsTests()
        {
            this.flatRepresentationBuilderWithReductions = new FlatRepresentationBuilderWithReductions(0);
        }

        private readonly FlatRepresentationBuilderWithReductions flatRepresentationBuilderWithReductions;

        [Fact]
        public void Build_Then_ResultShouldContainExpectedInOrder()
        {
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 1);
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("kg")), false, 2);
            var expected = FlatUnit.CreateFlatRepresentation(new FlatUnit("s"), new FlatUnit("kg", 2));

            var result = this.flatRepresentationBuilderWithReductions.Build();

            result.Should().ContainInOrder(expected);
        }

        [Fact]
        public void HasReduced_When_AddedUnitsHasNotPreviouslyBeenAdded_Then_ResultShouldBeFalse()
        {
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 1);
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("kg")), false, 2);

            var result = this.flatRepresentationBuilderWithReductions.HasReductions;

            result.Should().BeFalse();
        }

        [Fact]
        public void Reductions_When_AddedUnitsHasNotPreviouslyBeenAdded_Then_ResultShouldBeEmpty()
        {
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 1);
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("kg")), false, 2);

            var result = this.flatRepresentationBuilderWithReductions.Reductions;

            result.Should().BeEmpty();
        }

        [Fact]
        public void Reductions_When_AddedUnitsHasPreviouslyBeenAdded_Then_ResultShouldBeTrue()
        {
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 1);
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 2);

            var result = this.flatRepresentationBuilderWithReductions.HasReductions;

            result.Should().BeTrue();
        }

        [Fact]
        public void Reductions_When_AddedUnitsHasPreviouslyBeenAdded_Then_ResultShouldSingleReduction()
        {
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 1);
            this.flatRepresentationBuilderWithReductions.Add(new UnitExpression(new Unit("s")), false, 2);

            var result = this.flatRepresentationBuilderWithReductions.Reductions;

            result.Should()
                .ContainSingle(
                    reduction => reduction.ReducedUnit.Notation == "s" && reduction.TargetUnit.Notation == "s");
        }
    }
}