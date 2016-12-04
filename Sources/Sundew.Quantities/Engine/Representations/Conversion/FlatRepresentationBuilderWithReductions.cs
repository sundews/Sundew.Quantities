// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatRepresentationBuilderWithReductions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Conversion
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Extends <see cref="FlatRepresentationBuilder"/> with the reduction made when adding <see cref="Expression"/>s.
    /// </summary>
    public sealed class FlatRepresentationBuilderWithReductions : FlatRepresentationBuilder
    {
        private readonly LinkedList<Reduction> reductions;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlatRepresentationBuilderWithReductions"/> class.
        /// </summary>
        /// <param name="identifierCapacity">The identifier capacity.</param>
        public FlatRepresentationBuilderWithReductions(int identifierCapacity = 3)
            : base(identifierCapacity)
        {
            this.reductions = new LinkedList<Reduction>();
        }

        /// <summary>
        /// Gets the reductions.
        /// </summary>
        /// <value>The reductions.</value>
        public IEnumerable<Reduction> Reductions => this.reductions;

        /// <summary>
        /// Gets a value indicating whether this instance has reductions.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has reductions; otherwise, <c>false</c>.
        /// </value>
        public bool HasReductions { get; private set; }

        /// <summary>
        /// Called when a unit has been reduced.
        /// </summary>
        /// <param name="targetUnitExpression">The target unit expression.</param>
        /// <param name="reducedUnitExpression">The reduced unit expression.</param>
        protected override void OnUnitReduced(UnitExpression targetUnitExpression, UnitExpression reducedUnitExpression)
        {
            base.OnUnitReduced(targetUnitExpression, reducedUnitExpression);
            this.reductions.AddLast(new Reduction(targetUnitExpression.Unit, reducedUnitExpression.Unit));
            this.HasReductions = true;
        }
    }
}