// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatVariable.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;

namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
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