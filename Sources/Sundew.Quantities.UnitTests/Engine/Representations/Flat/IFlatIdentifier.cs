// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IFlatIdentifier.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using Sundew.Quantities.Engine.Representations.Flat;

    internal interface IFlatIdentifier
    {
        string Id { get; }

        IFlatIdentifierRepresentation GetFlatIdentifierRepresentation();
    }
}