namespace Sundew.Quantities.Engine.Representations.Flat
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Flat presentation of an identifier.
    /// </summary>
    public interface IFlatIdentifierRepresentation : IEquatable<IFlatIdentifierRepresentation>
    {
        /// <summary>
        /// Converts this instance to the resulting expression.
        /// </summary>
        /// <returns>A <see cref="Expression"/>.</returns>
        Expression ToResultingExpression();
    }
}