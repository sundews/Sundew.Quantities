namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using System;

    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Flat;

    public class FlatConstant : IFlatIdentifier
    {
        private readonly double constant;

        public FlatConstant(double constant, double exponent)
        {
            this.constant = Math.Pow(constant, exponent);
        }

        public string Id => FlatRepresentationBuilder.Constant;

        public IFlatIdentifierRepresentation GetFlatIdentifierRepresentation()
        {
            return new ConstantFlatIdentifierRepresentation(this.constant);
        }
    }
}