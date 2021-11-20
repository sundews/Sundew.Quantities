// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatConstant.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Flat;

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