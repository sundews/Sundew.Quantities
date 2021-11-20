// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatUnit.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Flat;

using System.Linq;
using Sundew.Quantities.Representations.Expressions;
using Sundew.Quantities.Representations.Flat;
using Sundew.Quantities.Representations.Units;

internal class FlatUnit : IFlatIdentifier
{
    private readonly string baseNotation;

    private readonly double exponent;

    private readonly string notation;

    private readonly bool reduceByBaseNotation;

    public FlatUnit(string notation, double exponent)
        : this(notation, notation, false, exponent)
    {
    }

    public FlatUnit(
        string notation,
        string baseNotation = null,
        bool reduceByBaseNotation = true,
        double exponent = 1)
    {
        if (baseNotation == null)
        {
            baseNotation = notation;
        }

        this.baseNotation = baseNotation;
        this.notation = notation;
        this.reduceByBaseNotation = reduceByBaseNotation;
        this.exponent = exponent;
    }

    public string Id => this.reduceByBaseNotation ? this.baseNotation : this.notation;

    public static FlatRepresentation CreateFlatRepresentation(params IFlatIdentifier[] flatIdentifiers)
    {
        var flatRepresentations = flatIdentifiers.ToDictionary(
            flatUnit => flatUnit.Id,
            flatUnit => flatUnit.GetFlatIdentifierRepresentation());
        return new FlatRepresentation(flatRepresentations);
    }

    public IFlatIdentifierRepresentation GetFlatIdentifierRepresentation()
    {
        return new UnitFlatIdentifierRepresentation(new UnitExpression(new Unit(this.notation)), this.exponent);
    }
}