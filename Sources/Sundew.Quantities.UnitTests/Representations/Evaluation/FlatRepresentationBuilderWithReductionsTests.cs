// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatRepresentationBuilderWithReductionsTests.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Evaluation
{
    using FluentAssertions;
    using Sundew.Quantities.Representations.Evaluation;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Sundew.Quantities.UnitTests.Representations.Flat;
    using Xunit;

    public class FlatRepresentationBuilderWithReductionsTests
    {
        private readonly FlatRepresentationBuilderWithReductions flatRepresentationBuilderWithReductions;

        public FlatRepresentationBuilderWithReductionsTests()
        {
            this.flatRepresentationBuilderWithReductions = new FlatRepresentationBuilderWithReductions(0);
        }

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