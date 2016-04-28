namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using Sundew.Quantities.Engine.Representations.Flat;

    internal interface IFlatIdentifier
    {
        string Id { get; }

        IFlatIdentifierRepresentation GetFlatIdentifierRepresentation();
    }
}