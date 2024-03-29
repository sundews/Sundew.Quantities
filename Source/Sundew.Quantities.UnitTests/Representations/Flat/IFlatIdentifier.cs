// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFlatIdentifier.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitTests.Representations.Flat;

using Sundew.Quantities.Representations.Flat;

internal interface IFlatIdentifier
{
    string Id { get; }

    IFlatIdentifierRepresentation GetFlatIdentifierRepresentation();
}