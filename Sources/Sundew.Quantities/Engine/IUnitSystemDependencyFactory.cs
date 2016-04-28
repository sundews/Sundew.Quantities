namespace Sundew.Quantities.Engine
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Operations;
    using Sundew.Quantities.Engine.Parsing;
    using Sundew.Quantities.Engine.Registration;
    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    /// <summary>
    /// Interface for implementing factory for unit system dependencies.
    /// </summary>
    public interface IUnitSystemDependencyFactory
    {
        /// <summary>
        /// Creates the expression converter.
        /// </summary>
        /// <returns>An <see cref="IExpressionToFlatRepresentationConverter"/>.</returns>
        IExpressionToFlatRepresentationConverter CreateExpressionConverter();

        /// <summary>
        /// Creates the unit registry.
        /// </summary>
        /// <returns>An <see cref="UnitRegistry"/>.</returns>
        UnitRegistry CreateUnitRegistry();

        /// <summary>
        /// Creates the parser.
        /// </summary>
        /// <param name="unitRegistry">The unit registry.</param>
        /// <returns>An <see cref="IExpressionParser" />.</returns>
        IExpressionParser CreateParser(IUnitRegistry unitRegistry);

        /// <summary>
        /// Creates the unit factory.
        /// </summary>
        /// <param name="derivedUnitRegistry">The derived unit registry.</param>
        /// <returns>An <see cref="IUnitFactory" />.</returns>
        IUnitFactory CreateUnitFactory(IDerivedUnitRegistry derivedUnitRegistry);

        /// <summary>
        /// Creates the parser.
        /// </summary>
        /// <param name="expressionParser">The expression parser.</param>
        /// <param name="unitFactory">The unit factory.</param>
        /// <returns>
        /// An <see cref="IQuantityParser" />.
        /// </returns>
        IQuantityParser CreateParser(IExpressionParser expressionParser, IUnitFactory unitFactory);

        /// <summary>
        /// Creates the quantity operations.
        /// </summary>
        /// <param name="unitFactory">The unit factory.</param>
        /// <returns>An <see cref="IQuantityOperations"/>.</returns>
        IQuantityOperations CreateQuantityOperations(IUnitFactory unitFactory);

        /// <summary>
        /// Creates the lexical analyzer.
        /// </summary>
        /// <param name="tokenMatchers">The token matchers.</param>
        /// <returns>A new <see cref="LexicalAnalyzer"/>.</returns>
        ILexicalAnalyzer CreateLexicalAnalyzer(IEnumerable<TokenMatcher> tokenMatchers);
    }
}