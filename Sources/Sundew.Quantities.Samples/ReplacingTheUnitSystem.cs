// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ReplacingTheEngine.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Samples
{
    using System.Collections;
    using System.Collections.Generic;

    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Operations;
    using Sundew.Quantities.Engine.Parsing;
    using Sundew.Quantities.Engine.Registration;
    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;

    using Xunit;

    public class ReplacingTheUnitSystem
    {
        [Fact(Skip = "Sample")]
        public void ReplacingEngine()
        {
            #region UsageInitializeUnitSystem

            // Initialize the unit system with a custom implementation of the IUnitSystemDependencyFactory interface.
            var unitSystemDependencies = UnitSystem.InitializeWithDefaults(null, new CustomUnitSystemDependencyFactory());
            
            #endregion
        }

        #region UsageCustomDependencyFactory

        // When implementing the IUnitSystemDependencyFactory interface, developers may choose whether to use the built-in classes or provide a custom implementation of the following interfaces:
        // - IExpressionToFlatRepresentationConverter
        // - ILexicalAnalyzer
        // - UnitRegistry
        // - IExpressionParser
        // - IUnitFactory
        // - IQuantityParser
        // - IQuantityOperations
        public class CustomUnitSystemDependencyFactory : IUnitSystemDependencyFactory
        {
            private static readonly ValueFromBaseVisitor ValueFromBaseVisitor = DefaultVisitors.ValueFromBaseVisitor;

            private static readonly ValueToBaseVisitor ValueToBaseVisitor = DefaultVisitors.ValueToBaseVisitor;

            private readonly IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter = new ExpressionToFlatRepresentationConverter();

            public IExpressionToFlatRepresentationConverter CreateExpressionConverter()
            {
                return this.expressionToFlatRepresentationConverter;
            }
            
            public ILexicalAnalyzer CreateLexicalAnalyzer(IEnumerable<TokenMatcher> tokenMatchers)
            {
                return new LexicalAnalyzer(tokenMatchers);
            }

            public UnitRegistry CreateUnitRegistry()
            {
                return new UnitRegistry(this.expressionToFlatRepresentationConverter);
            }

            public IExpressionParser CreateParser(IUnitRegistry unitRegistry)
            {
                var tokenMatcherBuilder = new TokenMatcherBuilder();
                var prefixTokenMatchers = tokenMatcherBuilder.Build(unitRegistry.GetPrefixNotations(), true);
                var unitTokenMatchers = tokenMatcherBuilder.Build(unitRegistry.GetUnitNotations(), false);
                var unitExpressionParser = new UnitExpressionParser(
                    unitRegistry,
                    new LexicalAnalyzer(new[] { prefixTokenMatchers, unitTokenMatchers }));
                return new ExpressionParser(unitExpressionParser);
            }

            public IUnitFactory CreateUnitFactory(IDerivedUnitRegistry derivedUnitRegistry)
            {
                return new UnitFactory(
                    this.expressionToFlatRepresentationConverter,
                    new ExpressionRewriter(),
                    derivedUnitRegistry);
            }

            public IQuantityParser CreateParser(IExpressionParser expressionParser, IUnitFactory unitFactory)
            {
                return new QuantityParser(expressionParser, unitFactory);
            }

            public IQuantityOperations CreateQuantityOperations(IUnitFactory unitFactory)
            {
                return new Engine.Operations.QuantityOperations(
                    unitFactory,
                    new ExpressionReducer(this.expressionToFlatRepresentationConverter),
                    ValueFromBaseVisitor,
                    ValueToBaseVisitor);
            }
        }

        #endregion
    }
}