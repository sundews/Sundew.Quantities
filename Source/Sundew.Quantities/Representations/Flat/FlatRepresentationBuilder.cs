// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlatRepresentationBuilder.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Flat;

using System;
using System.Collections.Generic;
using Sundew.Quantities.Representations.Expressions;

/// <summary>
/// Builder for <see cref="FlatRepresentation"/> of <see cref="Expression"/>
/// </summary>
public class FlatRepresentationBuilder
{
    internal const string Constant = "?C";

    private readonly IDictionary<string, UnitFlatIdentifierRepresentation> unitFlatIdentifierRepresentations;

    private int additionalCount;

    private ConstantFlatIdentifierRepresentation constantFlatIdentifierRepresentation;

    private IDictionary<string, VariableFlatIdentifierRepresentation> variableFlatIdentifierRepresentations;

    /// <summary>
    /// Initializes a new instance of the <see cref="FlatRepresentationBuilder"/> class.
    /// </summary>
    /// <param name="identifierCapacity">The identifier capacity.</param>
    public FlatRepresentationBuilder(int identifierCapacity = 3)
        : this(new Dictionary<string, UnitFlatIdentifierRepresentation>(identifierCapacity))
    {
    }

    internal FlatRepresentationBuilder(
        IDictionary<string, UnitFlatIdentifierRepresentation> unitFlatIdentifierRepresentations)
    {
        this.unitFlatIdentifierRepresentations = unitFlatIdentifierRepresentations;
    }

    /// <summary>
    /// Adds the specified unit expression.
    /// </summary>
    /// <param name="unitExpression">The unit expression.</param>
    /// <param name="reduceUsingBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
    /// <param name="exponent">The exponent.</param>
    public void Add(UnitExpression unitExpression, bool reduceUsingBaseUnits, double exponent)
    {
        var unit = unitExpression.Unit;
        var unitNotation = unit.Notation;
        if (reduceUsingBaseUnits)
        {
            unitNotation = unit.BaseUnit.Notation;
        }

        if (this.unitFlatIdentifierRepresentations.TryGetValue(unitNotation, out var flatExpressionRepresentation))
        {
            this.OnUnitReduced(flatExpressionRepresentation.UnitExpression, unitExpression);
            unitExpression = flatExpressionRepresentation.UnitExpression;
            exponent += flatExpressionRepresentation.Exponent;
        }

        this.unitFlatIdentifierRepresentations[unitNotation] = new UnitFlatIdentifierRepresentation(
            unitExpression,
            exponent);
    }

    /// <summary>
    /// Adds the specified constant expression.
    /// </summary>
    /// <param name="constantExpression">The constant expression.</param>
    /// <param name="exponent">The exponent.</param>
    public void Add(ConstantExpression constantExpression, double exponent)
    {
        var additionalConstant = Math.Pow(constantExpression.Constant, exponent);
        if (this.constantFlatIdentifierRepresentation == null)
        {
            this.constantFlatIdentifierRepresentation = new ConstantFlatIdentifierRepresentation(additionalConstant);
            this.additionalCount++;
        }
        else
        {
            this.constantFlatIdentifierRepresentation =
                new ConstantFlatIdentifierRepresentation(
                    this.constantFlatIdentifierRepresentation.Constant * additionalConstant);
        }
    }

    /// <summary>
    /// Adds the specified variable expression.
    /// </summary>
    /// <param name="variableExpression">The variable expression.</param>
    /// <param name="exponent">The exponent.</param>
    public void Add(VariableExpression variableExpression, double exponent)
    {
        if (this.variableFlatIdentifierRepresentations == null)
        {
            this.variableFlatIdentifierRepresentations =
                new Dictionary<string, VariableFlatIdentifierRepresentation>();
        }

        var variableName = variableExpression.VariableName;
        if (this.variableFlatIdentifierRepresentations.TryGetValue(variableName, out var flatExpressionRepresentation))
        {
            exponent += flatExpressionRepresentation.Exponent;
        }
        else
        {
            this.additionalCount++;
        }

        this.variableFlatIdentifierRepresentations[variableName] =
            new VariableFlatIdentifierRepresentation(variableExpression, exponent);
    }

    /// <summary>
    /// Builds a <see cref="FlatRepresentation"/> from this instance.
    /// </summary>
    /// <returns>A <see cref="FlatRepresentation"/>.</returns>
    public FlatRepresentation Build()
    {
        var flatPresentations =
            new Dictionary<string, IFlatIdentifierRepresentation>(
                this.unitFlatIdentifierRepresentations.Count + this.additionalCount);
        foreach (var pair in this.unitFlatIdentifierRepresentations)
        {
            if (!pair.Value.Exponent.Equals(0))
            {
                flatPresentations.Add(pair.Key, pair.Value);
            }
        }

        this.unitFlatIdentifierRepresentations.Clear();

        if (this.constantFlatIdentifierRepresentation != null)
        {
            flatPresentations.Add(Constant, this.constantFlatIdentifierRepresentation);
            this.constantFlatIdentifierRepresentation = null;
        }

        if (this.variableFlatIdentifierRepresentations != null)
        {
            foreach (var pair in this.variableFlatIdentifierRepresentations)
            {
                if (!pair.Value.Exponent.Equals(0))
                {
                    flatPresentations.Add(pair.Key, pair.Value);
                }
            }

            this.variableFlatIdentifierRepresentations.Clear();
        }

        return new FlatRepresentation(flatPresentations);
    }

    /// <summary>
    /// Called when units are reduced.
    /// </summary>
    /// <param name="targetUnitExpression">The target unit expression.</param>
    /// <param name="reducedUnitExpression">The reduced unit expression.</param>
    protected virtual void OnUnitReduced(UnitExpression targetUnitExpression, UnitExpression reducedUnitExpression)
    {
    }
}