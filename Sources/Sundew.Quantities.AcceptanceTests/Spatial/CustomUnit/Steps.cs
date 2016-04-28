namespace Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Spatial.UnitSelection;

    public static class StepExtensions
    {
        public static Expression Steps(this IDistanceUnitSelector distanceUnitSelector)
        {
            return new DerivedUnit(new ConstantExpression((1 / 53.4323198) / 1000) * UnitDefinitions.Meter).GetExpression();
        }
    }
}