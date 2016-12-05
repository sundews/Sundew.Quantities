// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatConstant.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Representations.Flat
{
    using System;
    using Sundew.Quantities.Representations.Flat;

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