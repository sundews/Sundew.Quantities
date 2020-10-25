// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatVariable.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Flat
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

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