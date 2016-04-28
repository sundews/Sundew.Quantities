namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using System.Linq;

    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;

    internal class FlatVariable : IFlatIdentifier
    {
        private readonly double exponent;

        public FlatVariable(string variableName, double exponent = 1)
        {
            this.Id = variableName;
            this.exponent = exponent;
        }

        public string Id { get; }

        public IFlatIdentifierRepresentation GetFlatIdentifierRepresentation()
        {
            return new VariableFlatIdentifierRepresentation(new VariableExpression(this.Id), this.exponent);
        }
    }
}