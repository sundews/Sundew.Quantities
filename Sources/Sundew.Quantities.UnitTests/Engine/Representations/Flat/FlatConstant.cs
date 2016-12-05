// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatConstant.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Representations;
using Sundew.Quantities.Representations.Flat;

namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using System;

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