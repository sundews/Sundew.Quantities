namespace Sundew.Quantities.Engine.Registration
{
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    /// <summary>
    /// Interface for implementing a derived unit registry.
    /// </summary>
    public interface IDerivedUnitRegistry
    {
        /// <summary>
        /// Tries to get the unit.
        /// </summary>
        /// <param name="flatRepresentation">The flat representation.</param>
        /// <param name="derivedUnit">The found derived unit.</param>
        /// <returns>
        ///   <c>true</c> if the flat representation is found, otherwise <c>false</c>
        /// </returns>
        bool TryGetUnit(FlatRepresentation flatRepresentation, out DerivedUnit derivedUnit);

        /// <summary>
        /// Tries to get the prefix.
        /// </summary>
        /// <param name="prefixFactor">The prefix factor.</param>
        /// <param name="prefix">The found prefix.</param>
        /// <returns>
        ///   <c>true</c> if the prefix factor is found, otherwise <c>false</c>
        /// </returns>
        bool TryGetPrefix(double prefixFactor, out Prefix prefix);
    }
}