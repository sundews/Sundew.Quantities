// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatVariable.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

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